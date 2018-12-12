using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace Task1.Infrastructure.HttpHandlers
{
    public class ImageHttpHandler : IHttpHandler
    {
        public bool IsReusable => throw new NotImplementedException();

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;
            HttpRequest request = context.Request;
            var segment = request.RequestContext.RouteData;
            var filename = segment.Values["id"];

            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string pathToFile = @"Pictures\" + filename + ".jpg";
            string myPath = Path.Combine(appPath, pathToFile);

            if (File.Exists(myPath))
            {
                byte[] imageData = File.ReadAllBytes(myPath);
                response.ContentType = "image/jpg";
                response.BinaryWrite(imageData);
            }
            else
            {
                response.Write("<h1>There is no data to show</h1>");
            }
        }
    }
}