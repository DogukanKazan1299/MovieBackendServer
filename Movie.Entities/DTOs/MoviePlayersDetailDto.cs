using Movie.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Entities.DTOs
{
    public class MoviePlayersDetailDto : IDto
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string PlayerName { get; set; }
    }
}
