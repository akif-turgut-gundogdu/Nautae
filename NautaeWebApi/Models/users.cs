using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NautaeWebApi.Models
{
    public class users
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string comments { get; set; }
    }
}