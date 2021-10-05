using System;
using System.Collections.Generic;
using System.Linq;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioPropietario : IRepositorioPropietario
    {
        List<Propietario> propietarios;

        public RepositorioPropietario()
        {
            propietarios = new List<Propietario>()
            {
                new Propietario{Id=1,Nombre="Camilo",Apellido="Lopez",Telefono="2343545",Edad=22,Direccion="cra 12 546",IdentidadGenero="masculino",Email="juan@gmail.com",Consideraciones="El perro es agresivo"},
                new Propietario{Id=2,Nombre="Melissa",Apellido="Hurtado",Telefono="785545",Edad=12,Direccion="cl 3 45 56",IdentidadGenero="femenino",Email="mely@gmail.com",Consideraciones="El perro tiene muchas pulgas"},
                new Propietario{Id=3,Nombre="Luisa",Apellido="Quintero",Telefono="455665",Edad=45,Direccion="cl 4 cra 23 4",IdentidadGenero="femenino",Email="luisitap@gmail.com",Consideraciones="El gato es nervioso"}

            };
        }

        public Propietario Add(Propietario nuevoPropietario)
        {
           nuevoPropietario.Id=propietarios.Max(p => p.Id) +1; 
           propietarios.Add(nuevoPropietario);
           return nuevoPropietario;
        }

        

        public IEnumerable<Propietario> GetAll()
        {
            return propietarios;
        }

        public Propietario GetPropietarioPorId(int propietarioId)
        {
            return propietarios.SingleOrDefault(p => p.Id==propietarioId);
        }

        public IEnumerable<Propietario> GetPropietariosPorFiltro(string filtro=null) // el parámetro es opcional 
        {
            var propietarios = GetAll(); // Obtiene todos los propietarios
            if (propietarios != null)  //Si se tienen propietarios
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    propietarios = propietarios.Where(p => p.Email.Contains(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return propietarios;
        }

        public Propietario Update(Propietario propietarioActualizado)
        {
            var propietario= propietarios.SingleOrDefault(p => p.Id==propietarioActualizado.Id);
            if (propietario!=null)
            {
                propietario.Nombre = propietarioActualizado.Nombre;
                propietario.Apellido=propietarioActualizado.Apellido;
                propietario.Telefono=propietarioActualizado.Telefono;
                propietario.Edad=propietarioActualizado.Edad;
                propietario.Direccion=propietarioActualizado.Direccion;
                propietario.IdentidadGenero=propietarioActualizado.IdentidadGenero;
                propietario.Email=propietarioActualizado.Email;
                propietario.Consideraciones=propietarioActualizado.Consideraciones;
            }
            return propietario;
        }
          
    }
}