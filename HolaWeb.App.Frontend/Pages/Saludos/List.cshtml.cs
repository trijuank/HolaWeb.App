using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolaWeb.App.Dominio;
using HolaWeb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
       //private string[] saludos = { "Buenos dias", "Buenas tardes", "Buenas noches", "Hasta mañana" };
       // public List<string> ListaSaludos { get; set; }
       private readonly IRepositorioPropietario repositorioPropietario;
       public IEnumerable<Propietario> Propietarios {get;set;}

       [BindProperty(SupportsGet =true)]
       public string FiltroBusqueda { get; set; }


       public ListModel(IRepositorioPropietario repositorioPropietario)
       {
            this.repositorioPropietario=repositorioPropietario;
       }
       
        public void OnGet(string filtroBusqueda)
        {
           // ListaSaludos = new List<string>();
           // ListaSaludos.AddRange(saludos);
          FiltroBusqueda=filtroBusqueda;
          Propietarios=repositorioPropietario.GetPropietariosPorFiltro(filtroBusqueda);

        }
    }
}
