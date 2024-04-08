using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DTOLayer.AboutDTO
{
    public class ResultAboutDTO  // her işlem kendisi içinde yapılsın. 
    {
        public int AboutID { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
