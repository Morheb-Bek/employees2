using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace EmployeeSearch_4
{
	public class Countries
	{
		public string name { get; set; }
		public string code { get; set; }

		List<Countries> listofCountries = new List<Countries>();

		public void countryName(string code)
		{
			string allcountriesString = File.ReadAllText(@"CountriesJson");
			listofCountries = JsonConvert.DeserializeObject<List<Countries>>(allcountriesString);


			try
			{
				Countries cont = listofCountries.First(x => x.code == code);

				Console.WriteLine(" Employees in : " + cont.name);
				Employees empl1 = new Employees();
				empl1.searchName(cont.name);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}



			return;


		}
	}

}
