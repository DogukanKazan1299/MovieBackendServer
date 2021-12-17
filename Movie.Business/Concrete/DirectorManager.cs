using Movie.Business.Abstract;
using Movie.Business.BusinessAspect.Autofac;
using Movie.Business.Constants;
using Movie.Business.ValidationRules.FluentValidation;
using Movie.Core.Aspects.Autofac.Caching;
using Movie.Core.Aspects.Autofac.Performance;
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
    public class DirectorManager : IDirectorService
    {
        IDirectorDal _directorDal;

        public DirectorManager(IDirectorDal directorDal)
        {
            _directorDal = directorDal;
        }
        [ValidationAspect(typeof(DirectorValidator))]
        [SecuredOperation("Team.Add,Admin")]
        [CacheRemoveAspect("IDirectorService.Get")]
        public IResult Add(Director director)
        {
            _directorDal.Add(director);
            return new SuccessResult(Messages.AddDirector);
        }

        public IResult Delete(Director director)
        {
            _directorDal.Delete(director);
            return new SuccessResult(Messages.DeleteDirector);
        }
        [CacheAspect]
        public IDataResult<Director> GetById(int directorId)
        {
            return new SuccessDataResult<Director>(_directorDal.Get(x =>x.Id==directorId));
        }
        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Director>> GetList()
        {
            return new SuccessDataResult<List<Director>>(_directorDal.GetList().ToList());
        }

        public IResult Update(Director director)
        {
            _directorDal.Update(director);
            return new SuccessResult(Messages.UpdateDirector);
        }
    }
}
