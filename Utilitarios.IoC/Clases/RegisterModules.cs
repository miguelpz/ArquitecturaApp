using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace Utilitarios.IoC
{
    public class RegisterModules:IRegisterModules
    {
        private readonly IUnityContainer _contenedor;

        public RegisterModules(IUnityContainer contenedor)
        {
            _contenedor = contenedor;
        }

        public void RegisterType<TFrom, TTo>(bool withItercepcion = false) where TTo : TFrom
        {
            if (!withItercepcion)
            {
                _contenedor.RegisterType<TFrom, TTo>();
            }
        }

        public void RegisterTypeWithLifeTime<TFrom, TTo>(bool withItercepcion = false) where TTo : TFrom
        {
            if (!withItercepcion)
            {
                _contenedor.RegisterType<TFrom, TTo>(new ContainerControlledLifetimeManager());
            }
        }
    }
}
