using DotnetClassRecordStruct.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace DotnetClassRecordStruct.Controllers;

public class StructController : BaseController
{
    [HttpGet]
    public IActionResult Get()
        => Ok(new InfoOutput("It's allocated in STACK memory, that's really faster than HEAP one."));

    [HttpGet("when-use")]
    public IActionResult WhenUse()
        => Ok(new InfoOutput("To encapsulate a small amount of data, lightweight objects that are frequently created and destroyed."));

    private struct InfoOutput
    {
        public InfoOutput(string info)
        {
            Id = Guid.NewGuid();
            Info = info;
        }

        public Guid Id;
        public string Info;
    }
}
