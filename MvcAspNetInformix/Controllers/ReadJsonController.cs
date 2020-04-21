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
        
        public ActionResult GetData()
        {
            var cont = new WindsorContainer();
            cont.Install(new CastleWidsorConfiguration());
            IMasterConnection masterConnection = cont.Resolve<IMasterConnection>();
            
            List<Users> users = masterConnection.GetDataTable();
            return Json(users, JsonRequestBehavior.AllowGet);
        }
    }
}