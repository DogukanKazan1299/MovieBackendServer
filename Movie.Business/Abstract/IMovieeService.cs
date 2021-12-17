using Movie.Core.Utilities.Results;
using Movie.Entities.Concrete;
using Movie.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Business.Abstract
{
    public interface IMovieeService
    {
        IDataResult<List<Moviee>> GetList();
        IDataResult<Moviee> GetById(int movieId);
        IResult Add(Moviee moviee);
        IResult Delete(Moviee moviee);
        IResult Update(Moviee moviee);
        List<MovieDetailDto> GetMovieDetails();
    }
}
