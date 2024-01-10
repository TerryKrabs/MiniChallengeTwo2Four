using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwo2Four.Services.HigherOrLower;

namespace API_ControllersAndRoutes.Controllers;

[ApiController]
[Route("[controller]")]

 public class HigherOrLowerController : ControllerBase
 {
    private readonly IHigherOrLowerService _higherOrLowerService;

    public HigherOrLowerController(IHigherOrLowerService higherOrLowerService)
    {
        _higherOrLowerService = higherOrLowerService;
    }



    [HttpPost] 
    [Route("HigherOrLower/{num1}/{num2}")]

     public string HigherOrLower(int num1, int num2)
     {
        return _higherOrLowerService.HigherOrLower(num1, num2);
     }
 }

