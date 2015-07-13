using Ninject.Modules;

namespace T9_Spelling.BLL
{
    /// <summary>
    /// IoC for Dependency Injection
    /// </summary>
    public class ConfigModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IReplace>().To<Replace>();
        }
    }
}
