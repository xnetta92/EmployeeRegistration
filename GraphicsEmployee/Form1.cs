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
using Newtonsoft.Json;

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

        private void button_read_Click(object sender, EventArgs e)
        {
            updatelist();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            if (string.IsNullOrEmpty(textBox_name.Text))
            {
                MessageBox.Show("You must provide a name!");
                textBox_name.Focus();
                return;
            }
            employees.Name = textBox_name.Text;
            employees.Salary = (long)numericUpDown_salary.Value;
            employees.Position = textBox_position.Text;

            var json = JsonConvert.SerializeObject(employees);
            var data = new StringContent(json, Encoding.UTF8, "application/json"); //-- fejlécet adtunk hozzá
            var response = client.PostAsync(endPoint, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Update succesful!");
                updatelist();
            }
            else
            {
                MessageBox.Show("Upload failed!");
            }
            textBox_id.Text = string.Empty;
            textBox_name.Text = string.Empty;
            numericUpDown_salary.Text = string.Empty;
            textBox_position.Text = string.Empty;

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really want to delete it?") == DialogResult.OK)
            {
                Employees employees = new Employees();

                employees.Id = long.Parse(textBox_id.Text);
                string endPointDelete = $"{endPoint}/{employees.Id}";
                employees.Name = textBox_name.Text;
                employees.Salary = (long)numericUpDown_salary.Value;
                employees.Position = textBox_position.Text;


                string endPointUpdate = $"{endPoint}/{employees.Id}";
                var response = client.DeleteAsync(endPointUpdate).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Successful Delete!");
                    updatelist();
                }
                else
                {
                    MessageBox.Show("Delete failed!");
                }
                //-- delete input fields ---------------
                textBox_id.Text = string.Empty;
                textBox_name.Text = string.Empty;
                numericUpDown_salary.Value = numericUpDown_salary.Minimum;
                textBox_position.Text = string.Empty;

            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox_id.Text))
            {
                MessageBox.Show("You have not selected an employee!");
                return;
            }
            if (textBox_name.Text.Length < 3)
            {
                MessageBox.Show("Entering a name is mandatory!");
                textBox_name.Focus();
                return;
            }
            

            Employees employees = new Employees();

            employees.Id = long.Parse(textBox_id.Text);
            employees.Name = textBox_name.Text;
            employees.Salary = (long)numericUpDown_salary.Value;
            employees.Position = textBox_position.Text;

            var json = JsonConvert.SerializeObject(employees); 
            var data = new StringContent(json, Encoding.UTF8, "application/json"); 
            string endPointUpdate = $"{endPoint}/{employees.Id}";
            var response = client.PutAsync(endPointUpdate, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Successful editing!");
                updatelist();
            }
            else
            {
                MessageBox.Show("Editing failed!");
            }
            //-- delete input fields ---------------
            textBox_id.Text = string.Empty;
            textBox_name.Text = string.Empty;
            numericUpDown_salary.Value = numericUpDown_salary.Minimum;
            textBox_position.Text = string.Empty;
         
        }
    }
}
