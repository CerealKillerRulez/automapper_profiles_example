using Unity;

namespace WCF_Container_Example
{
    public class IoCProvider
    {
        private static IUnityContainer _IoC;

        public static IUnityContainer Instance {
            get{
                if (_IoC == null)
                    _IoC = new UnityContainer();

                return _IoC;
            }
        }
    }
}