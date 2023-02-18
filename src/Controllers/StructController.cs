using DotnetClassRecordStruct.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace DotnetClassRecordStruct.Controllers;

public class StructController : BaseController
{
    [HttpGet]
    public IActionResult Get()
        => Ok(new InfoOutput(Guid.NewGuid(), "It's allocated in STACK memory, that's really faster than HEAP one."));

    private struct InfoOutput
    {
        public InfoOutput(Guid id, string info)
        {
            Id = id;
            Info = info;
        }

        public Guid Id;
        public string Info;
    }
}
