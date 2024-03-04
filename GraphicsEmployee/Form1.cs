using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GraphicsEmployee
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrl");

        private static string ReadSetting(string keyName)
        {
            string result = null;
            try
            {
                var value = ConfigurationManager.AppSettings;
                result = value[keyName];
            }
            catch (ConfigurationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatelist();
        }

        private async void updatelist()
        {
            listBox_employees.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var employees = Employees.FromJson(jsonString);
                    foreach (Employees item in employees)
                    {
                        listBox_employees.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox_employees_SelectedIndexChanged(object sender, EventArgs e)
        {
                Employees employee = (Employees)listBox_employees.SelectedItem;
                textBox_id.Text = employee.Id.ToString();
                textBox_name.Text = employee.Name;
                numericUpDown_salary.Text = employee.Salary.ToString();
                textBox_position.Text = employee.Position;
            
        }
    }
}
