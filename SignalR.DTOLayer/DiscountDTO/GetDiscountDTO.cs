using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DTOLayer.DiscountDTO
{
    public class GetDiscountDTO
    {
        public int DiscountId { get; set; }
        public string Title { get; set; }
        public string Amount { get; set; } // miktar 
        public string ImageURL { get; set; }
        public string Description { get; set; }
    }
}
