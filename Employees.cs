using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
	class Employees
	{

		private int myVar;




		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int ID { get; set; }
		public string Country {get; set;}
		List<Employees> listofEmployees = new List<Employees>();

		public DateTime birthday { get; set; }
		public int newint;

		public bool saveEmp(Employees emp)
		{
			try
			{
				string emplString = File.ReadAllText(@"EmployeesJson");



				listofEmployees = JsonConvert.DeserializeObject<List<Employees>>(emplString);

				emp.ID = listofEmployees.Count + 1;

			}
			catch (Exception)
			{
				emp.ID = 1;
			}




			listofEmployees.Add(emp);
			string JsonConvertResult = JsonConvert.SerializeObject(listofEmployees);



			File.WriteAllText(@"EmployeesJson", JsonConvertResult);

			return true;
		}
		public List<Employees> searchName(string name)
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
			List<Employees> list1 = listofEmployees.Where(r => r.FirstName == name || r.Country == name).ToList();
			list1 = list1.OrderBy(x => x.FirstName).ToList();
			return list1;
		}
	}
}
