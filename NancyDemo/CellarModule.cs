using System.Linq;
using System.Linq.Expressions;
using Nancy;
using Nancy.ModelBinding;
using NancyDemo.Models;

namespace NancyDemo
{
    public class CellarModule : NancyModule
    {
        public CellarModule(ICellar cellar)
        {
            Get["/"] = _ => View["index"];

            Get["/{id:int}"] = ctx => cellar.GetAll().FirstOrDefault(b => b.Id == ctx.id);

            Get["/list"] = _ => cellar.GetAll();

            Post["/"] = ctx =>
            {
                cellar.Store(this.Bind<Bottle>());
                return 200;
            };
        }
    }
}