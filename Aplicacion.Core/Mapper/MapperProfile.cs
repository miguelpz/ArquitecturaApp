using AutoMapper;
using Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Core
{
    public class MapperProfile:Profile
    {

        public MapperProfile()
        {
            CreateMap<Casa, CasaDTO>();
            CreateMap<CasaDTO, Casa>();
        }

    }
}
