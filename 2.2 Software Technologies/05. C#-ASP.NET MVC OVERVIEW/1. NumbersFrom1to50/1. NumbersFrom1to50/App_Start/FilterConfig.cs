﻿using System.Web;
using System.Web.Mvc;

namespace _1.NumbersFrom1to50
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
