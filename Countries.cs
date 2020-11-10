using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
	class Countries
	{
		public string name { set; get; }
		public string code { set; get; }
		List<Countries> listofCountries = new List<Countries>();
	 
		
		public List<Countries> namesOfCountries()
		{
			 string[] cNames = { "" };
			string cRead = File.ReadAllText(@"countriesJson");
			listofCountries = JsonConvert.DeserializeObject<List<Countries>>(cRead);
		
			return listofCountries;
		}
		public void addCountry(Countries c)
		{
			string cRead = File.ReadAllText(@"countriesJson");
			listofCountries = JsonConvert.DeserializeObject<List<Countries>>(cRead);

			listofCountries.Add(c);
			string cWrite = JsonConvert.SerializeObject(listofCountries);
			File.WriteAllText(@"countriesJson", cWrite);
			return;
		}
		public string countryName(string code)
		{
			string allcountriesString = File.ReadAllText(@"CountriesJson");
			listofCountries = JsonConvert.DeserializeObject<List<Countries>>(allcountriesString);

		
			try
			{
				Countries cont = listofCountries.First(x => x.code == code);
				return cont.name;
				
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return ("error");
			}



			


		}
	}

}
