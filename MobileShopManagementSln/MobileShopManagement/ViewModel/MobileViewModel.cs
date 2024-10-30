using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopManagement.ViewModel
{
    public class MobileViewModel
    {
        public int MobileId { get; set; }
        public string MobileModel { get; set; }
        public string MobileName { get; set; }
        public DateTime LaunchDate { get; set; }
        public string MobileType { get; set; }
        public bool IsStock { get; set; }
        public int TotalPrice { get; set; }
        public string MobileVersionTitle { get; set; }
        public string ImagePath { get; set; }
    }
}
