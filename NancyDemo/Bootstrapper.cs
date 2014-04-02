using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy.TinyIoc;
using NancyDemo.Models;

namespace NancyDemo
{
    public class Bootstrapper : Nancy.DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);
            container.Register<ICellar, Cellar>().AsMultiInstance();
        }
    }
}