using System.Collections.Generic;

namespace MvcAspNetInformix.Models
{
    public class ListingUsers
    {
        public int total { get; set; }
        public List<Users> newUsers { get; set; }
    }
}