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
    public class MovieCategoryManager : IMovieCategoryService
    {
        IMovieCategoryDal _movieCategoryDal;
        public MovieCategoryManager(IMovieCategoryDal movieCategoryDal)
        {
            _movieCategoryDal = movieCategoryDal;
        }

        public IResult Add(MovieCategory movieCategory)
        {
            _movieCategoryDal.Add(movieCategory);
            return new SuccessResult(Messages.AddMovieCategory);
        }

        public IResult Delete(MovieCategory movieCategory)
        {
            _movieCategoryDal.Delete(movieCategory);
            return new SuccessResult(Messages.DeleteMovieCategory);
        }

        public IDataResult<MovieCategory> GetById(int Id)
        {
            return new SuccessDataResult<MovieCategory>(_movieCategoryDal.Get(x => x.Id == Id));
        }

        public IDataResult<List<MovieCategory>> GetList()
        {
            return new SuccessDataResult<List<MovieCategory>>(_movieCategoryDal.GetList().ToList());
        }

        public List<MovieCategoriesDetailDto> GetMovieCategoriesDetailDtos()
        {
            return _movieCategoryDal.GetMovieCategoriesDetailDtos();
        }

        public IResult Update(MovieCategory movieCategory)
        {
            _movieCategoryDal.Update(movieCategory);
            return new SuccessResult(Messages.UpdateMovieCategory);
        }
    }
}
