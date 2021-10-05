using System.Collections.Generic;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietario
    {
        IEnumerable<Propietario> GetAll();
        IEnumerable<Propietario> GetPropietariosPorFiltro(string filtro);
        Propietario GetPropietarioPorId(int propietarioID);
        Propietario Update(Propietario propietarioActualizado);
        Propietario Add(Propietario nuevoPropietario);
      


    }
}