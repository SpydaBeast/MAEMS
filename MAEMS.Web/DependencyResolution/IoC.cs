using StructureMap;
using MAEMS.Data;
using MAEMS.Web.Infrastructure;

namespace MAEMS.Web {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            //                x.For<IExample>().Use<Example>();
                            x.For<IEventDataSource>().HttpContextScoped().Use<EventDb>();
                        });
            return ObjectFactory.Container;
        }
    }
}