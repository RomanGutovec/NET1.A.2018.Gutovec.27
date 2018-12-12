using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Infrastructure.HttpHandlers
{
    public class HandlerSelectionModule : IHttpModule
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication application)
        {
            application.PostResolveRequestCache += (src, args) =>
            {
                if (string.Equals((string)application.Context.Request.RequestContext.RouteData.Values["controller"],
                    "Home", StringComparison.OrdinalIgnoreCase) &&
                        string.Equals((string)application.Context.Request.RequestContext.RouteData.Values["action"],
                        "Index", StringComparison.OrdinalIgnoreCase))
                {
                    application.Context.RemapHandler(new ImageHttpHandler());
                }
            };
        }
    }
}