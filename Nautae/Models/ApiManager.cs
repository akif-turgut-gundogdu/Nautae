using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautae.Models
{

    class ApiManager
    {
        static ApiManager defaulInstance = new ApiManager();
        public static ApiManager DefaultManager
        {
            get { return defaulInstance; }
            set { defaulInstance = value; }
        }

    }

}
