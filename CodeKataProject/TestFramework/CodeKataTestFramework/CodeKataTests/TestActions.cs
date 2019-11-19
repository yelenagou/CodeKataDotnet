using NUnit.Framework;
using MyExtendConfiguration;
using System;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace CodeKataTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConfigurationExtensions_ValidateIsLoaded_ReturnsNull()
        {
            IConfiguration config = null;
            Assert.IsFalse(config.IsLoaded());
        }   
        [Test]
        public void AddStandardProviders_ValidateProviders_ReturnProviders()
        {
            var builder = new ConfigurationBuilder();
            var config = builder.AddStandardProvicers().Build();
            Assert.AreEqual(4, config.Providers.Count());
            Assert.IsTrue(config.IsLoaded());
        }
    }
}