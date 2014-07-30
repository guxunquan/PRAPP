using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using PersonalResolvedApp.BLL;
using PersonalResolvedApp.IBLL;
using PersonalResolvedApp.DAO;
using PersonalResolvedApp.IDAO;

namespace PersonalResolvedApp.core
{
    public class DependencyRegisterType
    {
        public static void Container_Sys(ref UnityContainer container)
        {
            container.RegisterType<INewIndexIBLL, NewIndexBLL>();//样例
            container.RegisterType<INewIndexIDAO, NewIndexDAO>();
        }
    }
}
