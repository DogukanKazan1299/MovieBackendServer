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
    public class EfMoviePlayerDal : EfEntityRepositoryBase<MoviePlayer, MovieSystemContext>, IMoviePlayerDal
    {
        public List<MoviePlayersDetailDto> GetMoviePlayersDetailDtos()
        {
            using (MovieSystemContext context = new MovieSystemContext())
            {

                var result = from mp in context.MoviePlayers
                             join
                             m in context.Movies on mp.MovieId equals m.Id
                             join
                             p in context.Players on mp.PlayerId equals p.Id
                             select new MoviePlayersDetailDto
                             {
                                 Id = mp.Id,
                                 MovieName = m.MovieName,
                                 PlayerName = p.Name
                             };
                return result.ToList();


            }
        }
    }
}
