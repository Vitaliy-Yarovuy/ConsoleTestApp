using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
	class Program
	{
		static void Main(string[] args)
		{


			ResourceOne.Culture = CultureInfo.CreateSpecificCulture("nl-NL");   
			Console.WriteLine("Hello World! " + ResourceOne.test);
			Console.ReadKey();
		}
	}
}
