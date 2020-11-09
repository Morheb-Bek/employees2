using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSearch_4
{
	  public class Options
	{
		static public string printOptions()
		{
			Console.WriteLine("enter 1 to add Employee");
			Console.WriteLine("enter 2 to search by name");
			Console.WriteLine("enter 3 search for country ID");
			Console.WriteLine("enter 0 to Exit");
			return (Console.ReadLine());
		}
	}
}
