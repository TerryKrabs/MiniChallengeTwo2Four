using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwo2Four.Services.addingNumbers;
// namespace MiniChallengeTwo2Four.Controllers;
namespace API_ControllersAndRoutes.Controllers;

[ApiController]
[Route("[controller]")]

 public class addingNumbersController : ControllerBase
 {
    private readonly IaddingNumbersService _addingNumbersService;

    public addingNumbersController(IaddingNumbersService addingNumbersService)
    {
        _addingNumbersService = addingNumbersService;
      
    }


    [HttpPost] 
    [Route("RentMoney/{userInput}/{userInput2}")]


    public string RentMoney(int userInput, int userInput2)
    {
    
        return _addingNumbersService.RentMoney(userInput, userInput2);
    }

 }
