using Movie.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Entities.Concrete
{
    public class MoviePlayer : IEntity
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int PlayerId { get; set; }
    }
}
