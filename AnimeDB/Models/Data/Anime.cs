using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeDB.Models.Data
{
    public class Anime
    {
        public ushort Id { get; set; }
        public string Name { get; set; }
        public byte TypeId { get; set; }
        public byte StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte AgeRatingId { get; set; }
        public byte LicensorsId { get; set; }
        public byte StudioID { get; set; }
        public List<Author> Authors { get; set; }
        public List<Character> Characters { get; set; }
    }
}
