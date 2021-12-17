using Movie.Core.DataAccess;
using Movie.Entities.Concrete;
using Movie.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DataAccess.Abstract
{
    public interface IMovieCategoryDal : IEntityRepository<MovieCategory>
    {
        List<MovieCategoriesDetailDto> GetMovieCategoriesDetailDtos();
    }
}
