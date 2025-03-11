using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4_NET8.Shared
{
    public class FootballClub
    {
        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public string Country { get; set; }
        public int FoundedYear { get; set; }
        public string StadiumName { get; set; }
        public int Capacity { get; set; }   

        public override string ToString()
        {
            return $"{this.ClubName} ({this.Country}) - {this.FoundedYear} - {this.StadiumName} ({this.Capacity})";
        }
    }
}
