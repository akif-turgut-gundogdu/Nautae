using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautae.Models
{
    public class users
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string comments { get; set; }



        public users(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
        public users() { }
        //public bool CheckInformation()
        //{
        //    if (!this.userName.Equals(null) && !this.password.Equals(null))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
