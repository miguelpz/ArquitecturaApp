using Datos.Persistencia.Core;
using Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios.IoC;

namespace Datos.Persistencia.Implementacion.init
{
    [Export(typeof(IModule))]

    public class ModuleInit:IModule
    {
        public void Initialize(IRegisterModules register)
        {
            register.RegisterType<IContextoUnidadDeTrabajo, ContextoPrincipal>();
            register.RegisterType<ICasaRepositorio, CasaRepositorio>();        
        }
    }
}
