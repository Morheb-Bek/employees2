using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace EmployeeSearch_4
	
{
	public class Employees
	{

		List<Employees> listofEmployees = new List<Employees>();
		public string firstName { get; set; }
		public string lastName { get; set; }
		public int ID { get; set; }
		public string country { get; set; }
		public int numbreOfCars { get; set; }


		public void printOptions()
		{
			Console.WriteLine("Type 1 to enter new employee");
			Console.WriteLine("Type 2 to serch by name");
			Console.WriteLine("Type 3 to search by country code");
			Console.WriteLine("Type 0 to exit");
		}
		public Employees requestInfo()
		{
			Console.WriteLine("enter the first name");
			string fname = Console.ReadLine();
			Console.WriteLine("enter the last name");
			string lname = Console.ReadLine();
			Console.WriteLine("enter country");
			string country = Console.ReadLine();
			Employees emp1 = new Employees();
			emp1.firstName = fname;
			emp1.lastName = lname;
			emp1.country = country;
			return emp1;
		}
		 public void addEmployee(Employees emp1)
		{
			

			try
			{
				string emplString = File.ReadAllText(@"EmployeesJson");



			listofEmployees = JsonConvert.DeserializeObject<List<Employees>>(emplString);

				emp1.ID = listofEmployees.Count + 1;

			}
			catch (Exception e)
			{
				emp1.ID = 1;
			}



			
			listofEmployees.Add(emp1);
			string JsonConvertResult = JsonConvert.SerializeObject(listofEmployees);
			//	string mfile = File.ReadAllText(@"EmployeeJson");



			File.WriteAllText(@"EmployeesJson", JsonConvertResult);



			Console.WriteLine("saved");
		}
		public void searchName(string name)
		{
			try
			{
				File.ReadAllText(@"EmployeesJson");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			string allNamesString = File.ReadAllText(@"EmployeesJson");
			listofEmployees = JsonConvert.DeserializeObject<List<Employees>>(allNamesString);
			List<Employees> list1= listofEmployees.Where(r => r.firstName == name || r.country == name).ToList();


			foreach (Employees e in list1)
			{
				Console.WriteLine("name: " + e.firstName + " " + e.lastName);
				Console.WriteLine("country :" + e.country);

			}
		}


	}
	
}
