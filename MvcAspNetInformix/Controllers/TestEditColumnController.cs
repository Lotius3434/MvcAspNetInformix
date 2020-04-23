using Castle.Windsor;
using MvcAspNetInformix.DbConnection;
using MvcAspNetInformix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAspNetInformix.Controllers
{
    public class TestEditColumnController : Controller
    {
        // GET: TestEditColumn
        public ActionResult CreateColumn()
        {
            return View();
        }
        public ActionResult UpdateColumn(int id, string surname,string name,string patronymicName)
        {
            var cont = new WindsorContainer();
            cont.Install(new CastleWidsorConfiguration());
            IMasterConnection masterConnection = cont.Resolve<IMasterConnection>();
            SqlMaster sqlMaster = new SqlMaster();

            ResulResponse ResulResponse = masterConnection.EditDataTable(sqlMaster.UpdateColumn(id, surname, name, patronymicName));

            return Json(ResulResponse, JsonRequestBehavior.AllowGet);
        }
        public ActionResult DeleteColumn()
        {
            return View();
        }
        
    }
}