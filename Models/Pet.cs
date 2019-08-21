using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Pet
    { 
        [Key]
        public int PetId { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public String PetName { get; set; }
        [DisplayName("Pet Type")]
        public String PetType { get; set; }
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public String Description { get; set; }

    }
}
