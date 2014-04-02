using System;

namespace NancyDemo.Models
{
    public class Bottle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WineColor Color { get; set; }
        public int Year { get; set; }
        public string Region { get; set; }
    }
}