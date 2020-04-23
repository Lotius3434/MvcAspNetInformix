using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAspNetInformix.Models
{
    public class ListingUsers
    {
        public int total { get; set; }
        public List<Users> newUsers { get; set; }
    }
}