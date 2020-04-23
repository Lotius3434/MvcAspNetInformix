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
    public class EditColumnController : Controller
    {
        public ActionResult CreateColumn(string surname, string name, string patronymicName)
        {
            var cont = new WindsorContainer();
            cont.Install(new CastleWidsorConfiguration());
            IMasterConnection masterConnection = cont.Resolve<IMasterConnection>();
            SqlMaster sqlMaster = new SqlMaster();

            ResulResponse resulResponse = masterConnection.EditDataTable(sqlMaster.CreateColumn(surname, name, patronymicName));

            return Json(resulResponse, JsonRequestBehavior.AllowGet);
        }
        public ActionResult UpdateColumn(int id, string surname, string name, string patronymicName)
        {
            var cont = new WindsorContainer();
            cont.Install(new CastleWidsorConfiguration());
            IMasterConnection masterConnection = cont.Resolve<IMasterConnection>();
            SqlMaster sqlMaster = new SqlMaster();

            ResulResponse resulResponse = masterConnection.EditDataTable(sqlMaster.UpdateColumn(id, surname, name, patronymicName));

            return Json(resulResponse, JsonRequestBehavior.AllowGet);
        }
        public ActionResult DeleteColumn(int id)
        {
            var cont = new WindsorContainer();
            cont.Install(new CastleWidsorConfiguration());
            IMasterConnection masterConnection = cont.Resolve<IMasterConnection>();
            SqlMaster sqlMaster = new SqlMaster();

            ResulResponse resulResponse = masterConnection.EditDataTable(sqlMaster.DeleteColumn(id));

            return Json(resulResponse, JsonRequestBehavior.AllowGet);
        }
    }
}