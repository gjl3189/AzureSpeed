﻿namespace AzureSpeed.WebUI.Controllers
{
    using System;
    using System.Web.Mvc;
    using NLog;

    public class BaseController : Controller
    {
        protected static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException(nameof(filterContext));
            }

            Logger.Error(filterContext.Exception);
            base.OnException(filterContext);
        }
    }
}