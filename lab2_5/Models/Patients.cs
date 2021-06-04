using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lab2_5.Models
{
    public class PatientModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Diagnosis is required")]
        [Display(Name = "Diagnosis")]
        public string Diagnosis { get; set; }

        [Required(ErrorMessage = "Diagnosis is required")]
        [Display(Name = "Age")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Display(Name = "Phones")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"8+9+[0-9]{9}", ErrorMessage = "Invalid data")]
        public string Phones { get; set; }
    }
}