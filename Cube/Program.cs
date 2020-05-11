using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the file name of a cube that you would like to work with");
            string adress = Console.ReadLine();
            CubeConsoleInterface cube = new CubeConsoleInterface(adress);
            cube.Show();
            cube.Volume();
            cube.SurfaceArea();

        }
    }
}
