using System;
using Unity;

namespace DataAccessLayer
{
    public static class Bootstraper
    {
        public static void Register(IUnityContainer container)
        {            
            container
               .RegisterType<IGeoCode, GeoCode>();      

        }
    }
}
