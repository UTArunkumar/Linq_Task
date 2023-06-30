using BLL.Interface;
using BLL.Service;
using DAL.Interface;
using DAL.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Infrastructureclass
{
    public  class InfrastructureConfiguration
    {
        public static void AddServices(IServiceCollection service)
        {
            service.AddTransient<IBusinesssample, Businesssample>();
            service.AddTransient<IDatasample, Datasample>();
        }
    }
}
