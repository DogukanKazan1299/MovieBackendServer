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
    public interface IMovieCategoryService
    {
        IDataResult<List<MovieCategory>> GetList();
        IDataResult<MovieCategory> GetById(int Id);
        IResult Add(MovieCategory movieCategory);
        IResult Delete(MovieCategory movieCategory);
        IResult Update(MovieCategory movieCategory);
        List<MovieCategoriesDetailDto> GetMovieCategoriesDetailDtos();
    }
}
