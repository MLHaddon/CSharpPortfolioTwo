using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioTwo.Controllers
{
    public class PortfolioController : Controller {
      // Session Based Methods and variables

      // Routes and middleware
      [HttpGet("")]
      public ViewResult Index()
      {
        return View();
      }
      [HttpGet("projects")]
      public ViewResult Projects()
      {
        return View("Projects");
      }
      [HttpGet("contact")]
      public ViewResult Contact()
      {
        return View("Contact");
      }
    }
}