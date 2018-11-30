using Aplicacion.Contratos;
using Aplicacion.Core;
using AutoMapper;
using Dominio.Contratos;
using Dominio.Core;
using System;
using System.Collections.Generic;

namespace Aplicacion.Implementacion
{
    public class CasaServicio : ICasaServicio
    {
        #region Atributos        
        private ICasaRepositorio _casaRepositorio;
        #endregion

        #region Construnctor       
        public CasaServicio(ICasaRepositorio pCasaRepositorio)
        {
            _casaRepositorio = pCasaRepositorio;
        }
        #endregion

        #region Métodos        
        public CasaDTO Obtener(int id)
        {
            var objeto = _casaRepositorio.Obtener(id);
            return Mapper.Map<Casa, CasaDTO>(objeto);
        }

        public IEnumerable<CasaDTO> ObtenerTodas()
        {
            var lista = _casaRepositorio.ObtenerTodas();
            return Mapper.Map<IEnumerable<Casa>, IEnumerable<CasaDTO>>(lista);
        }

        public IEnumerable<CasaDTO> BuscarPorCalle(string pDireccion)
        {
            var lista = _casaRepositorio.Buscar(x => x.Calle.ToUpper().Equals(pDireccion.ToUpper()));
            return Mapper.Map<IEnumerable<Casa>, IEnumerable<CasaDTO>>(lista);
        }

        public IEnumerable<CasaDTO> BuscarPorNumeroBaños(string pNumeroBaños)
        {
            var lista = _casaRepositorio.Buscar(x => x.NumeroBaños.Equals(pNumeroBaños));
            return Mapper.Map<IEnumerable<Casa>, IEnumerable<CasaDTO>>(lista);
        }

        public CasaDTO BuscarUnoPorCalle(string pCalle)
        {
            var objeto = _casaRepositorio.BuscarSingleOrDafault(x => x.Calle.ToUpper().Equals(pCalle.ToUpper()));
            return Mapper.Map<Casa, CasaDTO>(objeto);
        }

        public bool Agregar(CasaDTO entidad)
        {
            try
            {
                var _objetoInsertar = new Casa();
                Mapper.Map(entidad, _objetoInsertar);
                _casaRepositorio.Agregar(_objetoInsertar);
                _casaRepositorio.UnidadDeTrabajo.Completar();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool Eliminar(CasaDTO entidad)
        {
            try
            {
                var _objetoEliminar = new Casa();
                Mapper.Map(entidad, _objetoEliminar);
                _casaRepositorio.Eliminar(_objetoEliminar);
                _casaRepositorio.UnidadDeTrabajo.Completar();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Dispose        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_casaRepositorio != null)
                {
                    _casaRepositorio.Dispose();
                    _casaRepositorio = null;
                }
            }
        }
        #endregion
    }
}
