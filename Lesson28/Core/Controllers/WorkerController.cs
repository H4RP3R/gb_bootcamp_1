using Microsoft.AspNetCore.Mvc;

[ApiController]
// url/worker/getworker
[Route("[controller]")]
public class WorkerController : ControllerBase
{
    //   C   R   U    D 
    // post get put delete
    [HttpGet]
    [Route("getworker")]
    public Worker[] Get() => Repository.Read();

    [HttpGet]
    [Route("getworker/{id}")]
    public Worker Get(int id) => Repository.Read(id);
}