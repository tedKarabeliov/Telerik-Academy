using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaxThrottle.Utilities
{
    public static class SelectListDataGenerator
    {
        public static SelectList PopulateYears(object selectedValue = null)
        {
            const int YearInterval = 40;

            var years = new List<int>();

            var currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= currentYear - YearInterval; i--)
            {
                years.Add(i);
            }

            return new SelectList(years, selectedValue);
        }
    }
}