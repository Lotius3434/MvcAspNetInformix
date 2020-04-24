using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAspNetInformix.Models
{
    public class SqlResult
    {
        public string sql { get; set; }
        public ParamsUsers ParamsUsers { get; set; }
    }
}