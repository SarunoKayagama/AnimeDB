using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeDB.Models.Data
{
    public class Character
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public List<Anime> Animes { get; set; }
    }
}
