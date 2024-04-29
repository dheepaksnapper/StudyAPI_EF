using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyAPI.Data;
using StudyAPI.Entities;

namespace StudyAPI.Controllers;

[ApiController]
public class PlayerController : ControllerBase
{
    private readonly  DataContext _dataContext;
    public PlayerController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet()]
    [Route("api/[controller]")]
    public ActionResult<IEnumerable<Player>> GetPlayers()
    {
        return _dataContext.Players;
    }


}
