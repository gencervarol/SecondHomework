using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework
{
    class Dictionary<PN, FP>
    {   //PN: Player Number--FP: Football Player
        PN[] number;
        FP[] name;
        public Dictionary()
        {
            number = new PN[0];
            name = new FP[0];
        }
        public void Add(PN numbers, FP names)
        {
            PN[] tempNo = number;
            FP[] tempName = name;

            number = new PN[number.Length + 1];
            name = new FP[name.Length + 1];

            for (int i = 0; i < tempNo.Length; i++)
            {
                number[i] = tempNo[i];
            }
            number[number.Length - 1] = numbers;

            for (int i = 0; i < tempName.Length; i++)
            {
                name[i] = tempName[i];
            }
            name[name.Length - 1] = names;
        }

        public void ToList()
        {
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i] + ":" + name[i]);
            }


        }
    }
}
