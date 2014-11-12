using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaxThrottle.Constants
{
    public static class Globals
    {
        private static string noImageFoundPath = (string)System.Configuration.ConfigurationManager.AppSettings["NoImageFoundPath"].ToString();

        public static string NoImageFoundPath
        {
            get
            {
                return noImageFoundPath;
            }
        }
    }
}