﻿using System.Web;
using System.Web.Mvc;

namespace asp.net_admin_site_template
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
