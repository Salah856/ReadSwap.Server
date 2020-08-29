﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReadSwap.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppVersionController : ControllerBase
    {
        [HttpGet]
        public ActionResult ErrorLibrary()
        {
            var path =  Path.Combine(Directory.GetCurrentDirectory(), "ErrorLibrary", "ErrorCodes.json");
            Stream stream = new FileStream(path, FileMode.Open);

            if (stream == null)
                return NotFound(); 

            return File(stream, "application/octet-stream", "ErrorCodes.json"); 
        }
    }
}
