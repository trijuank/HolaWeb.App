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

    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario;
        public Propietario Propietario { get; set; }

        public DetailsModel(IRepositorioPropietario repositorioPropietario)
        {
            this.repositorioPropietario = repositorioPropietario;
        }
        public IActionResult OnGet(int propietarioId)
        {
            Propietario = repositorioPropietario.GetPropietarioPorId(propietarioId);
            if(Propietario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
