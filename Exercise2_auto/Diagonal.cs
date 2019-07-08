using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_auto
{
    public class Diagonal
    {
        public void DiagonalPrint(int topLimintNumber)
        {
            int space = 0;
            StringBuilder builder = new StringBuilder();
            builder.Append("Diagonal:").AppendLine();

            for (int i = 0; i < topLimintNumber; i++)
            {
                if (i == 0)
                {
                    builder.Append(i).AppendLine();
                }
                else if (i != 0)
                {
                    while (space != i)
                    {
                        builder.Append(" ");
                        space++;
                    }
                    builder.Append(i).AppendLine();
                    space = 0;
                }
            }
            string diagonal = builder.ToString();
            Console.WriteLine(diagonal);
        }

    }
}
