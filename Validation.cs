using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Validation
    {
        public int intInputValidation(int lowValue, int highValue)
        {
			int intInput;
			while (true)
			{
				string rawInput = Console.ReadLine();
				if (int.TryParse(rawInput, out intInput))
				{
					if (intInput >= lowValue && intInput <= highValue)
						return intInput;
					else
					{
						Console.WriteLine("out of range");
					}
				}
				else
				{
					Console.WriteLine("Incorrect value type");
				}
			}
		}
    }
}
