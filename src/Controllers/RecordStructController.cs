using DotnetClassRecordStruct.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace DotnetClassRecordStruct.Controllers;

public class RecordStructController : BaseController
{
    [HttpGet]
    public IActionResult Get()
        => Ok(new InfoOutput("It's allocated in STACK memory."));

    [HttpGet("when-use")]
    public IActionResult WhenUse()
        => Ok(new InfoOutput("To encapsulate a small amount of data, lightweight objects that are frequently created and destroyed. It's 20% faster than only structs."));

    private record struct InfoOutput
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