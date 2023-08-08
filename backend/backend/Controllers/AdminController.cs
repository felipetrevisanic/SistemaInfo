using backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace backend.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AdminController : ControllerBase
  {
    [HttpGet]
    public ActionResult ControleDeAdmin()
    {
      Admin admin = new Admin
      {
        Login = "SISTEMA",
        Senha = "candidato123"
      };

      return Ok(admin);
    }
  }
}
