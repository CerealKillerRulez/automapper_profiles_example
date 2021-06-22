using AutoMapper;
using Unity;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(WCF_Container_Example.App_Start.UnityWebFormsStart), "PostStart")]
namespace WCF_Container_Example.App_Start
{
	internal static class UnityWebFormsStart
	{

		internal static void PostStart()
		{
			RegisterDependencies(IoCProvider.Instance);
		}

		private static void RegisterDependencies(IUnityContainer container )
		{
			// TODO: Add any dependencies needed here
			container.RegisterInstance<IMapper>(new Mapper(AutoMapperFactory.BuildConfiguration()));
		}
	}
}