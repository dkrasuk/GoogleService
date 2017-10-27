using System;
using Unity;

namespace GoogleMapService.BusinessLayer
{
    public static class Bootstraper
    {
        public static void Register(IUnityContainer container)
        {
            DataAccessLayer.Bootstraper.Register(container);
            container
                .RegisterType<IGetGeoCodeService, GeoCodeService>();            
        }
    }
}
