using System;
using FakeItEasy;
using FluentAssertions;
using Nancy;
using Nancy.Testing;
using NancyDemo.Models;
using NUnit.Framework;

namespace NancyDemo.Tests
{
    [TestFixture]
    public class Tests
    {
        private ICellar _fakeCellar;
        private Browser _browser;

        //setuptest
        [SetUp]
        public void Setup()
        {
        }
        //gettest   
        [Test]
        public void cellar_should_return_200()
        {
        }

        //posttest
        [Test]
        public void post_to_cellar_should_work()
        {   
        }
    }
}
