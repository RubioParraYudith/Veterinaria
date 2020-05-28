﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace Veterinaria.Web.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        [MaxLength(100)]


        public string Name { get; set; }
        [Required]
        [Display(Name = "Tipo de Mascota")]
        [MaxLength(100)]

        public string PetType { get; set; }
        [Display(Name = "Edad")]

        public int Age { get; set; }
        [Display(Name = "Fecha de Nacimiento")]

        public DateTime BirthDate { get; set; }
        [Required]
        [Display(Name = "Color")]
        [MaxLength(100)]

        public string Color { get; set; }
        [Display(Name = "Raza")]
        [MaxLength(100)]

        public string Race { get; set; }
        [Required]
        [Display(Name = "Peso")]

        public decimal Weight { get; set; }
        [Required]
        [Display(Name = "Altura")]

        public decimal Height { get; set; }
        public string ImgUrl { get; set; }

        public int OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public Owner Owner { get; set; }
        public ICollection<Consult> Consults { get; set; }

    }
}