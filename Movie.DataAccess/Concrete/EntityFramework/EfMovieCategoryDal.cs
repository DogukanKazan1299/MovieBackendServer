using Movie.Core.DataAccess.EntityFramework;
using Movie.DataAccess.Abstract;
using Movie.DataAccess.Concrete.Contexts;
using Movie.Entities.Concrete;
using Movie.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DataAccess.Concrete.EntityFramework
{
    public class EfMovieCategoryDal : EfEntityRepositoryBase<MovieCategory, MovieSystemContext>, IMovieCategoryDal
    {
        public List<MovieCategoriesDetailDto> GetMovieCategoriesDetailDtos()
        {
            using (MovieSystemContext context = new MovieSystemContext())
            {
                var result = from mc in context.MovieCategories
                             join
                             m in context.Movies on mc.MovieId equals m.Id
                             join
                             c in context.Categories on mc.CategoryId equals c.Id
                             select new MovieCategoriesDetailDto
                             {
                                 Id = mc.Id,
                                 CategoryName = c.CategoryName,
                                 MovieName = m.MovieName
                             };
                return result.ToList();
                                
                             
            }
        }
    }
}
