using Castle.Windsor;
using MvcAspNetInformix.DbConnection;
using MvcAspNetInformix.DbConnection.WorkSql;
using MvcAspNetInformix.Models;
using System.Web.Mvc;

namespace MvcAspNetInformix.Controllers
{
    public class EditColumnController : Controller
    {
        public ActionResult CreateColumn(string surname, string name, string patronymicName)
        {
            var cont = new WindsorContainer();
            cont.Install(new CastleWidsorConfiguration());
            IMasterEditDataTable masterEditDataTable = cont.Resolve<IMasterEditDataTable>();
            ISqlMaster sqlMaster = cont.Resolve<ISqlMaster>();


            ResulResponse resulResponse = masterEditDataTable.EditDataTable(sqlMaster.CreateColumn(surname, name, patronymicName));

            return Json(resulResponse, JsonRequestBehavior.AllowGet);
        }
        public ActionResult UpdateColumn(int id, string surname, string name, string patronymicName)
        {
            var cont = new WindsorContainer();
            cont.Install(new CastleWidsorConfiguration());
            IMasterEditDataTable masterEditDataTable = cont.Resolve<IMasterEditDataTable>();
            ISqlMaster sqlMaster = cont.Resolve<ISqlMaster>();

            ResulResponse resulResponse = masterEditDataTable.EditDataTable(sqlMaster.UpdateColumn(id, surname, name, patronymicName));

            return Json(resulResponse, JsonRequestBehavior.AllowGet);
        }
        public ActionResult DeleteColumn(int id)
        {
            var cont = new WindsorContainer();
            cont.Install(new CastleWidsorConfiguration());
            IMasterEditDataTable masterEditDataTable = cont.Resolve<IMasterEditDataTable>();
            ISqlMaster sqlMaster = cont.Resolve<ISqlMaster>();

            ResulResponse resulResponse = masterEditDataTable.EditDataTable(sqlMaster.DeleteColumn(id));

            return Json(resulResponse, JsonRequestBehavior.AllowGet);
        }
    }
}