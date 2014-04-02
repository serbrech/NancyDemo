using System;
using System.Collections.Generic;

namespace NancyDemo.Models
{
    public interface ICellar
    {
        List<Bottle> GetAll();
        void Store(Bottle bottle);
    }

    public class Cellar : ICellar
    {
        public List<Bottle> GetAll()
        {
            return new List<Bottle>()
            {
                new Bottle()
                {
                    Color=WineColor.Red,
                    Id=1,
                    Name="Clochette du fou",
                    Year = 2003,
                    Region="Alsace"
                },
                new Bottle()
                {
                    Color=WineColor.White,
                    Id=2,
                    Name="Les Eglantiers",
                    Year = 2006, 
                    Region="Alsace"
                }
            };
        }

        public void Store(Bottle bottle)
        {
            
        }
    }
}