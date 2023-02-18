using DotnetClassRecordStruct.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace DotnetClassRecordStruct.Controllers;

public class ClassController : BaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
