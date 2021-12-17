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
    public class EfMovieeDal : EfEntityRepositoryBase<Moviee, MovieSystemContext>, IMovieDal
    {
        public List<MovieDetailDto> GetMovieDetails()
        {
            using (MovieSystemContext context = new MovieSystemContext())
            {
                var result = from m in context.Movies
                             join
                             d in context.Directors
                             on m.DirectorId equals d.Id
                             select new MovieDetailDto
                             {
                                 Id = m.Id,
                                 MovieName = m.MovieName,
                                 Name = d.Name,
                                 Surname=d.Surname
                             };
                return result.ToList();
            }
        }
    }
}
