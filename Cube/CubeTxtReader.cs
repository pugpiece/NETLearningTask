using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cube
{
    class CubeTxtReader
    {

        public List<double> CreateCubeList(string adress)
        {
            char[] separator = { ' ' };
            using (StreamReader fileIn = new StreamReader(adress + ".txt", Encoding.Default))
            {
                List<double> new_dots = new List<double>(24);

                for (int i = 0; i < 8; i++)
                {
                    string[] tempstring = fileIn.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < 3; j++)
                    {
                        double temp;
                        if (double.TryParse(tempstring[j], out temp))
                        {
                            new_dots.Add(temp);
                        }
                        else
                        {
                            throw new InvalidDataException("Incorrect data. Better luck next time :^)");
                        }
                    }
                }

                return new_dots;

            }
        }
    }
}
        
