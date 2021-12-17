using Movie.Core.Utilities.Results;
using Movie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Business.Abstract
{
    public interface IPlayerService
    {
        IDataResult<List<Player>> GetList();
        IDataResult<Player> GetById(int playerId);
        IResult Add(Player player);
        IResult Delete(Player player);
        IResult Update(Player player);

        IResult AddTransactionalTest(Player player);
    }
}
