using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClass.Service.Interfaces
{
    public interface IServiceFactory 
    {
        T GetServices<T>() where T : class;
    }
}
