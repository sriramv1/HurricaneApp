using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HApp.Model
{
    public class Shelter
    {
        public string ShelterName { get; set; }
        public string PhoneNo { get; set; }
        public string ImageUrl { get; set; }

        public List<Shelter> GetShelters()
        {
            List<Shelter> shelters = new List<Shelter>()
            {
                new Shelter()
                {
                    ShelterName = "Shelter 1",
                    PhoneNo = "8132789951",
                    ImageUrl = "https://cdn2.iconfinder.com/data/icons/snipicons/5000/home-24.png"
                },
                new Shelter()
                {
                    ShelterName = "Shelter 2",
                    PhoneNo = "8132789952",
                    ImageUrl = "https://cdn2.iconfinder.com/data/icons/snipicons/5000/home-24.png"
                },
                new Shelter()
                {
                    ShelterName = "Shelter 3",
                    PhoneNo = "8132789953",
                    ImageUrl = "https://cdn2.iconfinder.com/data/icons/snipicons/5000/home-24.png"
                },
                new Shelter()
                {
                    ShelterName = "Shelter 4",
                    PhoneNo = "8132789954",
                    ImageUrl = "https://cdn2.iconfinder.com/data/icons/snipicons/5000/home-24.png"
                },
                new Shelter()
                {
                    ShelterName = "Shelter 5",
                    PhoneNo = "8132789955",
                    ImageUrl = "https://cdn2.iconfinder.com/data/icons/snipicons/5000/home-24.png"
                },
                new Shelter()
                {
                    ShelterName = "Shelter 6",
                    PhoneNo = "8132789956",
                    ImageUrl = "https://cdn2.iconfinder.com/data/icons/snipicons/5000/home-24.png"
                }
            };
            return shelters;
        }
    }
}
