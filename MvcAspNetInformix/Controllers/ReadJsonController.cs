using Castle.Windsor;
using MvcAspNetInformix;
using MvcAspNetInformix.DbConnection;
using MvcAspNetInformix.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcTestTaskBars.Controllers
{
    public class ReadJsonController : Controller
    {
        
        public ActionResult GetData(int start,int limit)
        {
            var cont = new WindsorContainer();
            cont.Install(new CastleWidsorConfiguration());
            IMasterConnection masterConnection = cont.Resolve<IMasterConnection>();
            
            List<Users> users = masterConnection.GetDataTable();
            List<Users> newUsers = new List<Users>();
            int startIndex = start;
            for (int i = 0; i < limit; i++)
            {
                
                if (users[startIndex] != null)
                {
                    newUsers.Add(users[startIndex]);
                    startIndex++;
                }
                else
                {
                    break;
                }
            }
            return Json(newUsers, JsonRequestBehavior.AllowGet);
        }
    }
}