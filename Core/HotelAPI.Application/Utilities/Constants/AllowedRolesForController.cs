using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.Utilities.Constants
{
    public static class AllowedRolesForController
    {
        /// <summary>
        /// List of roles that are allowed to access the resource => ADMIN
        /// </summary>
        public const string Admin = "Admin";
        /// <summary>
        /// List of roles that are allowed to access the resource => ADMIN and USER
        /// </summary>
        public const string Admin_and_User = "Admin,User";
        /// <summary>
        /// List of roles that are allowed to access the resource => ADMIN and STAFF
        /// </summary>
        public const string Admin_and_Staff = "Admin,Staff";
        /// <summary>
        /// List of roles that are allowed to access the resource => ADMIN and STAFF
        /// </summary>
        public const string Admin_and_Staff_and_User = "Admin,Staff,User";


    }
}
