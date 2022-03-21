﻿using System.ComponentModel.DataAnnotations;

namespace Shopping.Entities
{
    public class Category
    {

        public int Id { get; set; }

        [Display(Name = "Categoría")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string Name { get; set; }
    }
}
