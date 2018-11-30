using Aplicacion.Core;
using System;
using System.Collections.Generic;

namespace Aplicacion.Contratos
{
    public interface ICasaServicio: IDisposable
    {
        CasaDTO Obtener(int id);

        IEnumerable<CasaDTO> ObtenerTodas();

        IEnumerable<CasaDTO> BuscarPorCalle(string pDireccion);

        IEnumerable<CasaDTO> BuscarPorNumeroBaños(string pNumeroBaños);

        CasaDTO BuscarUnoPorCalle(string pCalle);

        bool Agregar(CasaDTO entidad);

        bool Eliminar(CasaDTO entidad);
    }
}
