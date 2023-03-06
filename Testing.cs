using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Testing
    {
        public Testing()
        {
            Pack pack = new Pack();
            Validation validation = new Validation();
            int userInput = validation.intInputValidation();
            bool test = pack.shuffleCardPack(userInput);
        }
    }
}
