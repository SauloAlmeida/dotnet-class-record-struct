using DotnetClassRecordStruct.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace DotnetClassRecordStruct.Controllers;

public class ClassController : BaseController
{
    [HttpGet]
    public IActionResult Get()
        => Ok(new InfoOutput("It's allocated in HEAP memory, that's slower than STACK one."));

    [HttpGet("when-use")]
    public IActionResult WhenUse()
        => Ok(new InfoOutput("To a big amount of data."));

    private abstract class BaseInfo
    {
        public Guid Id { get; init; } = Guid.NewGuid();
    }

    private class InfoOutput : BaseInfo
    {
        public InfoOutput(string info)
        {
            Info = info;
        }

        public string Info;
    }
}