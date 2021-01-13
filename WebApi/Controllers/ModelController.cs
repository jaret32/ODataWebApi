using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApi.Controllers
{
    public class ModelController : ODataController
    {
        [HttpPost]
        public Model Post([FromBody] Model model)
        {
            Console.WriteLine(model.Html);
            return model;
        }
    }
}
