
using OnlineShoppingStore.Areas.Admin.ViewModels.BannerViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Models
{
    public class Banner
    {
        [Key]
        [Required]
        public int ID { get; private set; }

        public string ImagePath { get; private set; }

        public Banner()
        {
            //ForBlankObjectCreating
        }

        public Banner(BannerViewModel viewModel)
        {
            ImagePath = viewModel.ImagePath;
        }

    }
}
