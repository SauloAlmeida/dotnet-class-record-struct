using DotnetClassRecordStruct.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace DotnetClassRecordStruct.Controllers;

public class RecordController : BaseController
{
    [HttpGet]
    public IActionResult Get()
    => Ok(new InfoOutput(Guid.NewGuid(), "It's allocated in HEAP memory, that's slower than STACK one."));

    [HttpGet("when-use")]
    public IActionResult WhenUse()
        => Ok(new InfoOutput(Guid.NewGuid(), "When you need to create an object and don't need to change its properties after initialization, use a constructor to create a record without any properties."));

    private record InfoOutput(Guid id, string info);
}
