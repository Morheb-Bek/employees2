using System;
using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
namespace EmployeeSearch_4
{
	class Program
	{
	

		static void Main(string[] args)
		{
			string SearchCountry;
			
			string choice;
			string nameSearch;
			List<Employees> listofEmployees = new List<Employees>();
			List<Countries> listofCountries = new List<Countries>();
			
			do
			{

				choice = Options.printOptions();
				if (choice == "1")
				{
					Employees emp1 = new Employees();
					Employees emp =  emp1.requestInfo();
					emp1.addEmployee(emp);
				}

				else if (choice == "2")
				{
					Console.WriteLine("enter a name to search");
					nameSearch = Console.ReadLine();

					Employees employee  = new Employees();
					 employee.searchName(nameSearch);



				}
				else if (choice == "3")
				{
					Countries county1 = new Countries();
					Console.WriteLine("enter country Code");
					SearchCountry = Console.ReadLine();
				
					county1.countryName(SearchCountry);




				}

				} while (choice != "0") ;
			}
	} 
}
