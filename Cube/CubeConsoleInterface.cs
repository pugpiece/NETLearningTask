using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cube
{
    class CubeConsoleInterface
    {
        Cube cube;

        public CubeConsoleInterface(string adress)
        {
            try
            {
                    CubeTxtReader ctr = new CubeTxtReader();
                    List<double> new_dots = ctr.CreateCubeList(adress);
                    cube = new Cube(new_dots);
                    
            }
            catch (FileNotFoundException ex)
            {
                Console.Write("Exeption message:\n");
                Console.WriteLine(ex.Message);
                Console.Write("\n");
                Console.WriteLine("This file doesn't exist. Better luck next time :^)");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Write("Exeption message:\n");
                Console.WriteLine(ex.Message);
                Console.Write("\n");
                Console.WriteLine("Ammount of data is incorrect. Better luck next time :^)");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            catch (InvalidDataException ex)
            {
                Console.Write("Exeption message:\n");
                Console.WriteLine(ex.Message);
                Console.Write("\n");
                Console.WriteLine("The data is corrupted. Better luck next time :^)");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.Write("Exeption message:\n");
                Console.WriteLine(ex.Message);
                Console.Write("\n");
                Console.WriteLine("Can't interpriet dots as a cube. Better luck next time :^)");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            catch (NullReferenceException ex)
            {
                Console.Write("Exeption message:\n");
                Console.WriteLine(ex.Message);
                Console.Write("\n");
                Console.WriteLine("Incorrect ammount of data. Better luck next time :^)");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

        public void Show()
        {
            try
            {
                Console.WriteLine("Cube dots:");
                Console.WriteLine(cube.ToString());
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            catch (NullReferenceException ex)
            {
                Console.Write("Exeption message:\n");
                Console.WriteLine(ex.Message);
                Console.Write("\n");
                Console.WriteLine("The cube doesn't exist to show it's dots. Better luck next time :^)");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }

        }

        public void Volume()
        {
            try
            {
                Console.WriteLine("Cube volume = " + cube.Volume());
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            catch (NullReferenceException ex)
            {
                Console.Write("Exeption message:\n");
                Console.WriteLine(ex.Message);
                Console.Write("\n");
                Console.WriteLine("The cube doesn't exist to calculate it's volume. Better luck next time :^)");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

        public void SurfaceArea()
        {
            try
            {
                Console.WriteLine("Cube surface area = " + cube.SurfaceArea());
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            catch (NullReferenceException ex)
            {
                Console.Write("Exeption message:\n");
                Console.WriteLine(ex.Message);
                Console.Write("\n");
                Console.WriteLine("The cube doesn't exist to calculate it's surface area. Better luck next time :^)");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

    }
}
