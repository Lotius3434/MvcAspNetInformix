using MvcAspNetInformix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MvcAspNetInformix.Controllers
{
    public class TestReadJsonController : Controller
    {
        // GET: TestReadJson
        public ActionResult GetData(int start, int limit)
        {
            ListingUsers listingUsers = new ListingUsers();
            //get the Json filepath  
            string file = Server.MapPath("~/TestData/Users.json");
            //deserialize JSON from file  
            string json = System.IO.File.ReadAllText(file);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            
            
            var Userslist = ser.Deserialize<List<Users>>(json);

            List<Users> newUsers = new List<Users>();

            int startIndex = start;
            int Limit = limit;
            int totalLimit = Userslist.Count - start;
            if (totalLimit < Limit)
            {
                Limit = totalLimit;
            }

            for (int i = 0; i < Limit; i++)
            {
                newUsers.Add(Userslist[startIndex]);
                startIndex++;
            }
            listingUsers.total = Userslist.Count;
            listingUsers.newUsers = newUsers;

            return Json(listingUsers, JsonRequestBehavior.AllowGet);
        }
    }
}