using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HApp.Model;

namespace HApp.ViewModel
{
    public class ShelterViewModel
    {
        public List<Shelter> Shelters { get; set; }
        public ShelterViewModel()
        {
            Shelters = new Shelter().GetShelters();
        }

    }
}
