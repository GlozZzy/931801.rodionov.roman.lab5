using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lab2_5.Models
{
    public class HospitalModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Display(Name = "Phones")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"8+9+[0-9]{9}", ErrorMessage = "Invalid data")]
        public string Phones { get; set; }

    }
}