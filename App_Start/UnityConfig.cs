using System.Net.Http;
using System.Web.Http;
using todo_backend.DependencyInjections;
using todo_backend.Models;
using Unity;
using Unity.WebApi;

namespace todo_backend
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IDataAccessLayer, DataAccessLayer>();
            container.RegisterType<IBusinessLayer, BusinessLayer>();
            container.RegisterType<HttpResponseMessage>();

            container.RegisterType<TodoContext>();



            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}