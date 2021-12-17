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
using Movie.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Business.Concrete
{
    public class MovieeManager : IMovieeService
    {
        IMovieDal _movieDal;
        public MovieeManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }
        [ValidationAspect(typeof(MovieValidator))]
        [SecuredOperation("Movie.Add,Admin")]
        [CacheRemoveAspect("IMovieService.Get")]
        public IResult Add(Moviee moviee)
        {
            _movieDal.Add(moviee);
            return new SuccessResult(Messages.AddMovie);
        }

        public IResult Delete(Moviee moviee)
        {
            _movieDal.Delete(moviee);
            return new SuccessResult(Messages.DeleteMovie);
        }
        [CacheAspect]
        public IDataResult<Moviee> GetById(int movieId)
        {
            return new SuccessDataResult<Moviee>(_movieDal.Get(x => x.Id == movieId));
        }
        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Moviee>> GetList()
        {
            return new SuccessDataResult<List<Moviee>>(_movieDal.GetList().ToList());
        }

        public List<MovieDetailDto> GetMovieDetails()
        {
            return _movieDal.GetMovieDetails();
        }

        public IResult Update(Moviee moviee)
        {
            _movieDal.Update(moviee);
            return new SuccessResult(Messages.UpdateMovie);
        }
    }
}
