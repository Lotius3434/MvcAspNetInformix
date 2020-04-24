using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAspNetInformix.Models
{
    public class ParamsUsers
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymicName { get; set; }
    }
}