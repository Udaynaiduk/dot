using Microsoft.AspNetCore.Mvc;

[Route("api/[Controller]")]
[ApiController]
public class buildController:ControllerBase{

    [HttpGet]
    public IEnumerable<string> get(){
        return new string[]{"hello"};
    }
}

