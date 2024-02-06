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
        public const string ADMIN = "ADMIN";
        /// <summary>
        /// List of roles that are allowed to access the resource => ADMIN and OPERATOR
        /// </summary>
        public const string ADMIN_and_USER = "ADMIN,USER";

    }
}
