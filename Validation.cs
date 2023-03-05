using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Validation
    {
        public int intInputValidation()
        {
			int intInput;
			while (true)
			{
				Console.WriteLine("Please enter integer value:");
				string rawInput = Console.ReadLine();
				if (int.TryParse(rawInput, out intInput))
				{
					if (intInput > 0 && intInput < 4)
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
