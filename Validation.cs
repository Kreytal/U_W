using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Validation
    {	
		//Method that will produce both integer type validation and range validation
        public int intInputValidation(int lowValue, int highValue)
        {
			int intInput;
			while (true)
			{
                Console.WriteLine("Input value");
				//Get value from the user through input
				string rawInput = Console.ReadLine();
				//Parse the value as integer type and convert into intInput
				if (int.TryParse(rawInput, out intInput))
				{	
					//If try parse worked, proceed the range validation, if both conditions are met, the method returns the value
					if (intInput >= lowValue && intInput <= highValue)
						return intInput;
					else
					{
						Console.WriteLine($"The value is not in range of {lowValue} to {highValue}. Re-enter the value:");
					}
				}
				else
				{
					Console.WriteLine("You have entered incorrect value type. Re-enter the value:");
				}
			}
		}
    }
}
