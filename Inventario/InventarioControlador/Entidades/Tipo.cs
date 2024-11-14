﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioControlador.Entidades
{
    public class Tipo
    {
        public int Id { get; set; }
        //Data Notaciones, para configura el campo siguiente
        [Display(Name = "Tipo")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        //con el = null! es que no permite nulos
        public string Name { get; set; } = null!;
        //con el ? permite nulos
        public string? Categoria { get; set; }

    }
}
