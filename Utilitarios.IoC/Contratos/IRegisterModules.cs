namespace Utilitarios.IoC
{
    public interface IRegisterModules
    {
        void RegisterType<TFrom, TTo>(bool withItercepcion = false) where TTo : TFrom;
        void RegisterTypeWithLifeTime<TFrom, TTo>(bool withItercepcion = false) where TTo : TFrom;
    }
}
