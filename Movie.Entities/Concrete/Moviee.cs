using Movie.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Entities.Concrete
{
    public class Moviee : IEntity
    {
        public int Id { get; set; }
        public int DirectorId { get; set; }
        public string MovieName { get; set; }
    }
}
