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
        
        public ActionResult GetData(int page,int start,int limit)
        {
            List<List<Users>> pagesUsers = new List<List<Users>>();
            List<Users> newListusers;

            var cont = new WindsorContainer();
            cont.Install(new CastleWidsorConfiguration());
            IMasterConnection masterConnection = cont.Resolve<IMasterConnection>();
            
            List<Users> users = masterConnection.GetDataTable();

            //int totalPages = users.Count / limit;
            //if (totalPages == 0)
            //{
            //    totalPages = 1;
            //}

            //int startIndex = 0;

            //for (int i = 0; i < totalPages; i++)
            //{
            //    newListusers = new List<Users>();
            //    if (limit < users.Count || limit == users.Count)
            //    {
            //        for (int a = 0; a < limit; a++)
            //        {
            //            newListusers.Add(users[startIndex]);
            //            startIndex++;
            //        }
            //    }
            //    else
            //    {
            //        int newlimit = limit - users.Count;
            //        for (int a = 0; a < newlimit; a++)
            //        {
            //            newListusers.Add(users[startIndex]);
            //            startIndex++;
            //        }
            //    }
            //    pagesUsers.Add(newListusers);
            //    newListusers = null;
            //}




            return Json(users, JsonRequestBehavior.AllowGet);
        }
    }
}