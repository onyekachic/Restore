using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;

namespace API.Controllers
{
  public class BuggyController : BaseApiController
  {

    [HttpGet("not-found")]
    public ActionResult GetNotFound()
    {
      return NotFound();
    }

    [HttpGet("bad-request")]
    public ActionResult GetBadRequest()
    {
      return BadRequest(new ProblemDetails { Title = "this is a bad request" });
    }


    [HttpGet("unauthorised")]
    public ActionResult GetUnauthorised()
    {
      return Unauthorized();
    }


    [HttpGet("validation-error")]
    public ActionResult GetValidationError()
    {
      ModelState.AddModelError("Problem1", "This is the first Error ");
      ModelState.AddModelError("Problem1", "This is the second Error ");
      return ValidationProblem();
    }

    [HttpGet("server-error")]
    public ActionResult GetServerError()
    {
      throw new Exception("This is a Server Error");
    }

  }
}