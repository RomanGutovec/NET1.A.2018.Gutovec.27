using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using Task1.Infrastructure.HttpHandlers;

namespace Task1.Infrastructure.RouteHandlers
{
    public class CustomRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        => new ImageHttpHandler();
    }
}