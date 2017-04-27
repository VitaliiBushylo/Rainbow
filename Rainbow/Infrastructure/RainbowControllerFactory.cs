using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using Rainbow.Controllers;

namespace Rainbow.Infrastructure
{
    public class RainbowControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type controllerType;

            switch (controllerName.ToLower())
            {
                case "blue":
                    {
                        controllerType = typeof(Blue);
                        break;
                    }
                case "green":
                    {
                        controllerType = typeof(Green);
                        break;
                    }
                case "indigo":
                    {
                        controllerType = typeof(Indigo);
                        break;
                    }
                case "orange":
                    {
                        controllerType = typeof(Orange);
                        break;
                    }
                case "red":
                    {
                        controllerType = typeof(Red);
                        break;
                    }
                case "violet":
                    {
                        controllerType = typeof(Violet);
                        break;
                    }
                case "yellow":
                    {
                        controllerType = typeof(Yellow);
                        break;
                    }
                default:
                    {
                        requestContext.RouteData.Values["Controller"] = "Grey";
                        controllerType = typeof(Grey);
                        break;
                    }
            }
            
            return (IController)DependencyResolver.Current.GetService(controllerType); ;
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable contr = controller as IDisposable;
            contr?.Dispose();
        }
    }
}
