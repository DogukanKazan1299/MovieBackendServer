using Movie.Business.Abstract;
using Movie.Business.Constants;
using Movie.Business.ValidationRules.FluentValidation;
using Movie.Core.Aspects.Autofac.Caching;
using Movie.Core.Aspects.Autofac.Performance;
using Movie.Core.Aspects.Autofac.Transaction;
using Movie.Core.Aspects.Autofac.Validation;
using Movie.Core.Utilities.Results;
using Movie.DataAccess.Abstract;
using Movie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Business.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IPlayerDal _playerDal;
        public PlayerManager(IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }
        [ValidationAspect(typeof(PlayerValidator))]
        public IResult Add(Player player)
        {
            _playerDal.Add(player);
            return new SuccessResult(Messages.AddPlayer);
        }
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Player player)
        {
            Add(player);
            if (player.Age <0)
            {
                throw new Exception("");
            }
            Add(player);
            return null;
        }

        public IResult Delete(Player player)
        {
            _playerDal.Delete(player);
            return new SuccessResult(Messages.DeletePlayer);
        }
        [CacheAspect]
        public IDataResult<Player> GetById(int playerId)
        {
            return new SuccessDataResult<Player>(_playerDal.Get(x => x.Id == playerId));
        }
        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Player>> GetList()
        {
            return new SuccessDataResult<List<Player>>(_playerDal.GetList().ToList());
        }

        public IResult Update(Player player)
        {
            _playerDal.Update(player);
            return new SuccessResult(Messages.UpdatePlayer);
        }
    }
}
