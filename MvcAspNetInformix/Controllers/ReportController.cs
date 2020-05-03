using Castle.Windsor;
using MvcAspNetInformix.DbConnection;
using MvcAspNetInformix.DbConnection.WorkSql;
using MvcAspNetInformix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastReport;
using FastReport.Table;
using FastReport.Export.Pdf;
using FastReport.Web;
using System.IO;

namespace MvcAspNetInformix.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public FileResult GetReport()
        {
            ListingUsers listingUsers = new ListingUsers();

            var cont = new WindsorContainer();
            cont.Install(new CastleWidsorConfiguration());
            IMasterGetDataTable masterConnection = cont.Resolve<IMasterGetDataTable>();
            ISqlMaster sqlMaster = cont.Resolve<ISqlMaster>();
            List<Users> users = masterConnection.GetDataTable(sqlMaster.GetAllColumn());

            string reportName = "MvcAspFastReport.frx";
            string reportPath = $"FastReport/{reportName}";
            Stream stream = new MemoryStream();
            WebReport webReport = new WebReport();
            webReport.Report.Load(this.Server.MapPath("~/FastReport/MvcAspFastReport.frx"));
            //webReport.ReportFile = this.Server.MapPath("~/FastReport/MvcAspFastReport.frx");
            TableObject table = webReport.Report.FindObject("Table1") as TableObject;
            table.ColumnCount = 4;
            table.RowCount = users.Count;

            if (table != null)
            {
                for (int row = 0; row < users.Count; row++)// row строка
                {
                    table[0, row].Text = users[row].id.ToString();
                    table[1, row].Text = users[row].surname;
                    table[2, row].Text = users[row].name;
                    table[3, row].Text = users[row].patronymicName;

                    table[0, row].Border.Lines = BorderLines.All;
                    table[1, row].Border.Lines = BorderLines.All;
                    table[2, row].Border.Lines = BorderLines.All;
                    table[3, row].Border.Lines = BorderLines.All;
                }
                webReport.Report.Prepare();

                // сохраняем в нужном формате в поток

                webReport.Report.Export(new PDFExport(), stream);
                stream.Position = 0;



                //if (report.Prepare())
                //    report.ShowPrepared();

                //PDFExport pdf = new PDFExport();
                //report.Export(pdf, "ExportedPDF.pdf");

            }



            return File(stream, "application/zip", "report.pdf");
        }
    }
}