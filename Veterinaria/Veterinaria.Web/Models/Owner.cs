using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Web.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Nombre")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Display(Name = "Apellido")]
        [MaxLength(50)]

        public string LastName { get; set; }
        [Display(Name = "Dirección")]
        [MaxLength(400)]

        public string Address { get; set; }
        [Display(Name = "Teléfono")]
        [Required]
        [MaxLength(20)]

        public string Phone { get; set; }
        [Display(Name = "Correo Electronico")]
        [Required]
        [MaxLength(50)]

        public string Email { get; set; }

    }
}