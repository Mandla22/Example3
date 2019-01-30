using NUnit.Framework;
using Example_3.Controllers;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Tests {
    public class Tests {

        private ValuesController controller = new ValuesController();
        private HttpClient _http = new HttpClient();

        [Test]
        public void TestGetWithParameters() {
            var response = controller.Get(2).Value;
            Assert.AreEqual("value",  response);
        }

        [Test]
        public void TestGetNoParam() {
            var response = controller.Get().Value;
            string[] expected = new String[] { "value1", "value2" };

            Assert.AreEqual(expected, response);
        }

        [Test]
        public void TestPost() {

        }
    }
}