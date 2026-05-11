using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Register.Data
{
    public static class SessionManager
    {
        public static int CurrentUserID { get; set; }
        public static string CurrentUsername { get; set; }
        public static string CurrentRole { get; set; }
    }
}
