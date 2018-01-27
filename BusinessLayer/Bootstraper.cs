using System;
using Unity;

namespace GoogleMapService.GoogleBL
{
    public static class Bootstraper
    {
        public static void Register(IUnityContainer container)
        {
            GoogleDAL.Bootstraper.Register(container);
            container
                .RegisterType<IGetGeoCodeService, GeoCodeService>();            
        }
    }
}
