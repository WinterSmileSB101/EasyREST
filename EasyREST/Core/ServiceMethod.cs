using EasyREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyREST.Core
{
    [AttributeUsage(AttributeTargets.Method,AllowMultiple = true,Inherited = false)]
    class ServiceMethod: Attribute
    {
        private RequestMethods _Method;

        private ServiceMethod(RequestMethods RequestMethods)
        {
            _Method = RequestMethods;
        }

        public RequestMethods Method { get => _Method; }
    }
}
