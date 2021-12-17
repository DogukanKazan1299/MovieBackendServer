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
    public interface IMoviePlayerService
    {
        IDataResult<List<MoviePlayer>> GetList();
        IDataResult<MoviePlayer> GetById(int moviePlayerId);
        IResult Add(MoviePlayer moviePlayer);
        IResult Delete(MoviePlayer moviePlayer);
        IResult Update(MoviePlayer moviePlayer);
        List<MoviePlayersDetailDto> GetMoviePlayersDetailDtos();
    }
}
