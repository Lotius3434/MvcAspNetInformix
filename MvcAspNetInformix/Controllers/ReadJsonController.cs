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
            
            ListingUsers listingUsers = new ListingUsers();

            var cont = new WindsorContainer();
            cont.Install(new CastleWidsorConfiguration());
            IMasterConnection masterConnection = cont.Resolve<IMasterConnection>();
            SqlMaster sqlMaster = new SqlMaster();
            List<Users> users = masterConnection.GetDataTable(sqlMaster.GetAllColumn());

            int startIndex = start;
            int Limit = limit;
            int totalLimit = users.Count - start;
            if (totalLimit < Limit)
            {
                Limit = totalLimit;
            }

            List<Users> newUsers = new List<Users>();
            
            for (int i = 0; i < Limit; i++)
            {
                newUsers.Add(users[startIndex]);
                startIndex++;
            }
            
            listingUsers.total = users.Count;
            listingUsers.newUsers = newUsers;

            return Json(listingUsers, JsonRequestBehavior.AllowGet);
        }
    }
}