using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyREST.Core
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true,Inherited = false)]
    class ServiceRouter: Attribute
    {
        private string _RouterName;

        public ServiceRouter(string RouterName)
        {
            _RouterName = RouterName;
        }

        public string RouterName { get => _RouterName; }
    }
}
