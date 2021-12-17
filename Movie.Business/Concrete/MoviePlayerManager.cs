using Movie.Business.Abstract;
using Movie.Business.Constants;
using Movie.Core.Utilities.Results;
using Movie.DataAccess.Abstract;
using Movie.Entities.Concrete;
using Movie.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Business.Concrete
{
    public class MoviePlayerManager : IMoviePlayerService
    {
        IMoviePlayerDal _moviePlayerDal;
        public MoviePlayerManager(IMoviePlayerDal moviePlayerDal)
        {
            _moviePlayerDal = moviePlayerDal;
        }
        public IResult Add(MoviePlayer moviePlayer)
        {
            _moviePlayerDal.Add(moviePlayer);
            return new SuccessResult(Messages.AddMoviePlayer);
        }

        public IResult Delete(MoviePlayer moviePlayer)
        {
            _moviePlayerDal.Delete(moviePlayer);
            return new SuccessResult(Messages.DeleteMoviePlayer);
        }

        public IDataResult<MoviePlayer> GetById(int moviePlayerId)
        {
            return new SuccessDataResult<MoviePlayer>(_moviePlayerDal.Get(x => x.Id == moviePlayerId));
        }

        public IDataResult<List<MoviePlayer>> GetList()
        {
            return new SuccessDataResult<List<MoviePlayer>>(_moviePlayerDal.GetList().ToList());
        }

        public List<MoviePlayersDetailDto> GetMoviePlayersDetailDtos()
        {
            return _moviePlayerDal.GetMoviePlayersDetailDtos();
        }

        public IResult Update(MoviePlayer moviePlayer)
        {
            _moviePlayerDal.Update(moviePlayer);
            return new SuccessResult(Messages.UpdateMoviePlayer);
        }
    }
}
