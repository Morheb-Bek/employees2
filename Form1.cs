using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		List<Employees> listofEmployees = new List<Employees>();
		string selected = "start";

		public Form1()
		{

			InitializeComponent();
		}

		private void LabelBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (LabelBox.SelectedItem.ToString() != null)
			{
				selected = LabelBox.SelectedItem.ToString();
				button1.Text = " Submit";



			}

		}

		private void Button(object sender, EventArgs e)
		{
			switch (selected)
			{
				case "start":
					{
						flowLayoutPanel1.Visible = false;
						searchBox.Visible = false;
						label4.Text = "";
						selected = "wait";
						LabelBox.Items.Add("add an Employee");
						LabelBox.Items.Add("search Employee by name");
						LabelBox.Items.Add("search Employee by country code");
					}
					break;

				case "add an Employee":
					{
						LabelBox.Enabled = false;
						flowLayoutPanel1.Visible = true;
						selected = "submitEmployee";
						Countries countries = new Countries();
						List<Countries> listofCountries = countries.namesOfCountries();
						foreach (Countries c in listofCountries)
						{
							countrieBox.Items.Add(c.name);
						}
						countrieBox.Items.Add("other");
						countrieBox.SelectedIndex = 0;

					}
					break;

				case "submitEmployee":
					{


						Employees emp1 = new Employees();

						emp1.FirstName = FirstNameBox.Text;
						emp1.LastName = LastNameBox.Text;
						emp1.Country = countrieBox.SelectedItem.ToString();
						emp1.birthday = dateTimePicker1.Value;

						if (emp1.FirstName == "" || emp1.LastName == "")
						{

							label4.Visible = true;
							label4.Text = "Enter all required info";
							break;
						}



						if (emp1.Country == "other")
						{
							emp1.Country = otherCountryName.Text;
							otherbox.Enabled = true;
							Countries othercounrty = new Countries();
							othercounrty.name = otherCountryName.Text;
							othercounrty.code = othercountryCode.Text;
							othercounrty.addCountry(othercounrty);



						}
						bool success = emp1.saveEmp(emp1);
						if (success = true)
						{
							label4.Text = emp1.FirstName + " was added";
							LabelBox.Enabled = true;
							FirstNameBox.Clear();
							LastNameBox.Clear();
							otherCountryName.Clear();
							othercountryCode.Clear();



						}
					}
					break;

				case "search Employee by name":
					{
						searchBox.Visible = true;
						label7.Visible = true;

						selected = "nSearch";
					}
					break;
				case "nSearch":
					{
						Employees emp = new Employees();
						List<Employees> emp1 = emp.searchName(searchBox.Text);
						LabelBox.Items.Clear();
						if (emp1.Count == 0)
						{
							MessageBoxButtons buttons = MessageBoxButtons.OK;
							DialogResult result;

							// Displays the MessageBox.
							result = MessageBox.Show("name Not Found", "no such name", buttons);
							if (result == System.Windows.Forms.DialogResult.Yes)
							{
								// Closes the parent form.
								this.Close();
							}
						}
						LabelBox.Items.Add("search result");
						foreach (Employees em in emp1)
						{
							LabelBox.Items.Add(em.FirstName + " " + em.LastName);

						}

					}
					break;
				case "search Employee by country code":
					{
						searchBox.Visible = true;
						label7.Visible = true;

						selected = "cSearch";
					}
					break;
				case "cSearch":
					{
						Countries county = new Countries();
						string coname = county.countryName(searchBox.Text);
						LabelBox.Items.Clear();
						Console.WriteLine(" Employees in : " + coname);



						Employees empl1 = new Employees();
						List<Employees> listempl1 = empl1.searchName(coname);


						LabelBox.Items.Clear();
						LabelBox.Items.Add("search result for " + coname);
						foreach (Employees em in listempl1)
						{
							LabelBox.Items.Add(em.FirstName + " " + em.LastName);

						}

					}
					break;



			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void NameLabel_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void otherCountry_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void countrieBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (countrieBox.SelectedItem.ToString() == "other")
			{
				otherbox.Enabled = true;
			}
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void cancel_Click(object sender, EventArgs e)
		{
			LabelBox.Enabled = true;
			selected = "start";
			searchBox.Visible = false;
			LabelBox.Items.Clear();
			flowLayoutPanel1.Visible = false;

		}
	}
}
