using HelloWorld.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HelloWorldTest02.Controller
{
    [TestClass]
    public class HomeControllerTest
    {
        private HomeController _homeController;

        [TestMethod]
        public void Get_Home_Index_Should_Be_Null()
        {
            _homeController = new HomeController();
            var result = (ViewResult)_homeController.Index();
            result.Model.ShouldBeNull();
        }
    }
}
