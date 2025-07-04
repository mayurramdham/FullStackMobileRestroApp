using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIAssessmentFrontend.Utility
{
    public static class TokenHelper
    {
        public static string GetToken()
        {
            return Preferences.Get("jwtToken", string.Empty);
        }

        public static void ClearToken()
        {
            Preferences.Remove("jwtToken");
            Preferences.Remove("userName");
            Preferences.Remove("userId");
            Preferences.Remove("userImage");
            Preferences.Remove("email");
            Preferences.Remove("roleName");
        }
    }
}
