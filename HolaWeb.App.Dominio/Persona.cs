using System;
using System.ComponentModel.DataAnnotations;

namespace HolaWeb.App.Dominio{
    /// <summary>Class <c>Persona</c>
    /// Modela los datos generales de una persona en el sistema
    /// </summary> 
    public class Persona
    {

        public int Id { get; set; }
                [Required, StringLength(50)]
        public string Nombre { get; set; }
                [Required, StringLength(50)]
        public string Apellido { get; set; }
                [Required, StringLength(50)]
        public string Telefono { get; set; }
                [Required, StringLength(50)]
        public int Edad { get; set; }
                [Required, StringLength(50)]
        public string Direccion { get; set; }
                [Required, StringLength(50)]
        public string IdentidadGenero { get; set; }
               
    }
}