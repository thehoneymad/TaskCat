﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Newtonsoft.Json;
using System.Configuration;

[assembly: OwinStartup(typeof(TaskCat.App.Startup))]

namespace TaskCat.App
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            app.Properties["host.AppName"] = ConfigurationManager.AppSettings["AppName"];
            app.Properties["host.AppMode"] = ConfigurationManager.AppSettings["ENV"];

            //FIXME: We need a module to load development/production mode so error pages can be turned on/off
            //Better have a global configuration module like Asp.net 5, that looked awesome!
            if (app.Properties["host.AppMode"].ToString() == "development")
            {
                app.UseErrorPage();
            }

            //FIXME: Can be a small middleware. No? Alright!
            app.Run(context=> {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Welcome to TaskCat, proudly baked by NerdCats");
            });
        }
    }
}
