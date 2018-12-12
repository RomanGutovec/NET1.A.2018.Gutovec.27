using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Infrastructure.HttpModules
{
    public class ImageHttpModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += Application_BeginRequest;
            context.EndRequest += Application_EndRequest;
        }
        private void Application_EndRequest(object sender, EventArgs e)
        {
            ((HttpApplication)sender).Context.Response.Write("<h1>Good bye from HelloHttpModule</h1>");
        }

        private void Application_BeginRequest(object sender, EventArgs e)
        {
            ((HttpApplication)sender).Context.Response.Write("<h1>Hello from HelloHttpModule</h1>");
        }
    }
}