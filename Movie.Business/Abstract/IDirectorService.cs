using Movie.Core.Utilities.Results;
using Movie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Business.Abstract
{
    public interface IDirectorService
    {
        IDataResult<List<Director>> GetList();
        IDataResult<Director> GetById(int directorId);
        IResult Add(Director director);
        IResult Delete(Director director);
        IResult Update(Director director);
    }
}
