
using EGrocery.Areas.Admin.ViewModels.BannerViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGrocery.Models
{
    
        public class HomeIndexViewModel
        {
            public IEnumerable<BannerViewModel> Banners { get; set; }

            public IEnumerable<Product> Products { get; set; }
        }
    
}
