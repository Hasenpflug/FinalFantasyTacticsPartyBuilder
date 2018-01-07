using FinalFantasyTacticsPartyBuilder.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FinalFantasyTacticsPartyBuilder
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //if (bool.Parse(ConfigurationManager.AppSettings["MigrateDatabaseToLatestVersion"]))
            //{
            //    var configuration = new Migrations.Configuration();
            //    var migrator = new DbMigrator(configuration);
            //    migrator.Update();
            //}
        }
    }
}
