using System;
using System.ComponentModel.DataAnnotations;

namespace HolaWeb.App.Dominio{

    /// <summary>Class <c>propietario</c>
    /// Modela el propietario de la mascota
    /// </summary> 
    public class Propietario : Persona{

        [Required, StringLength(50)]
        public string Email { get; set; }
        [Required, StringLength(50)]
        public string Consideraciones { get; set; }
    }
}