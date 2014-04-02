using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Nancy.Conventions;
using Nancy.Extensions;
using Nancy.ViewEngines;

namespace NancyDemo.Conventions
{
    public class ListViewLocationConvention //: IConvention
    {
        public void Initialise(NancyConventions conventions)
        {
            conventions.ViewLocationConventions.Add((viewName, stuff, context) =>
            {
                var path = context.ModulePath.TrimStart(new[] { '/' });
                if (stuff == null) return string.Empty;
                var type = (Type)stuff.GetType();
                
                if (type.IsEnumerable() || type.IsCollection() && type.GenericTypeArguments.Any())
                {
                    var genericTypeName = type.GenericTypeArguments[0].Name;
                    viewName = genericTypeName + "list";
                    return string.Concat("views/", path, "/", context.ModuleName, "/", viewName);
                }
                
                return string.Empty;
            });
        }

        public Tuple<bool, string> Validate(NancyConventions conventions)
        {
            if (conventions.ViewLocationConventions == null)
            {
                return Tuple.Create(false, "The view conventions cannot be null.");
            }

            return (conventions.ViewLocationConventions.Count > 0) ?
                Tuple.Create(true, string.Empty) :
                Tuple.Create(false, "The view conventions cannot be empty."); 
        }
    }
}