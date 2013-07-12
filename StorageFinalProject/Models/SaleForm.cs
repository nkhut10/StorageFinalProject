using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StorageFinalProject.Models
{
    public class SaleForm
    {
        [Required]
        [Display(Name = "პროდუქტის კატეგორია")]
        public string Category { get; set; }

        [Required]
        [Display(Name = "პროდუქტის ტიპი")]
        public string ProductType { get; set; }

        [Required]
        [Display(Name = "საწყობის ნომერი")]
        public bool WarehouseID { get; set; }

        [Display(Name = "ერთეულის ფასი")]
        public bool Price { get; set; }

        [Display(Name = "რაოდენობა საწყობში")]
        public bool Quantity { get; set; }

    }
}