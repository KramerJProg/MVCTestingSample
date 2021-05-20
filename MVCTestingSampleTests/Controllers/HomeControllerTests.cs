using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCTestingSample.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCTestingSample.Controllers.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index_ReturnsNonNullViewResult()
        {
            HomeController myController = new HomeController();

            IActionResult result = myController.Index();

            Assert.IsNotNull(result);
        }
    }
}