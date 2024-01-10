using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeTwo2Four.Services.addingStrings
{
    public class addingStringsService : IaddingStringsService
    {
          public string HiltonHotel(string userName, string WakeUpTime)
    {
    
        return ($"Your Hotel is going to be under the name {userName} and Your checkout time will be {WakeUpTime}. Please enjoy your sleep at the Hilton Hotel");
    }

    }
}