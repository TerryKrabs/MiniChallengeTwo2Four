using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwo2Four.Services.addingStrings;
// namespace MiniChallengeTwo2Four.Controllers;
namespace API_ControllersAndRoutes.Controllers;

[ApiController]
[Route("[controller]")]

 public class addingStringsController : ControllerBase
 {
    private readonly IaddingStringsService _addingStringsService;

    public addingStringsController(IaddingStringsService addingStringsService)
    {
        _addingStringsService = addingStringsService;
    }


    [HttpPost] 
    [Route("HiltonHotel/{userName}/{WakeUpTime}")]

    public string HiltonHotel(string userName, string WakeUpTime)
    {
    
        return _addingStringsService.HiltonHotel(userName, WakeUpTime);
    }

 }
