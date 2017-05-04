using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMainMenu : Form
    {
        List<Object> Toys = new List<Object>();

        public FormMainMenu()
        {
            InitializeComponent();

            this.comboBox1.Items.AddRange(new object[] {
                    "Computer",
                    "Car",
                    "Plane",
                    "Submarine"
            });
                  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (comboBox1.Text)
            {
                case "Computer":
                        Computer computer = new Computer();
                        computer.SetName(textBox1.Text);
                        computer.SetPrice(Convert.ToDouble(textBox2.Text));
                    Toys.Add(computer);
                    break;

                case "Car":
                        Car car = new Car();
                        car.SetName(textBox1.Text);
                        car.SetPrice(Convert.ToDouble(textBox2.Text));
                        car.SetAcceleration(Convert.ToDouble(textBox3.Text));
                    Toys.Add(car);
                    break;

                case "Plane":
                        Plane plane = new Plane();
                        plane.SetName(textBox1.Text);
                        plane.SetPrice(Convert.ToDouble(textBox2.Text));
                        plane.SetAcceleration(Convert.ToDouble(textBox3.Text));
                        plane.SetRise(Convert.ToDouble(textBox5.Text));
                    Toys.Add(plane);

                    break;

                case "Submarine":
                        Submarine submarine = new Submarine();
                        submarine.SetName(textBox1.Text);
                        submarine.SetPrice(Convert.ToDouble(textBox2.Text));
                        submarine.SetAcceleration(Convert.ToDouble(textBox3.Text));
                        submarine.SetDive(Convert.ToDouble(textBox4.Text));
                    Toys.Add(submarine);
                    break; 
            }
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "Computer":
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    break;

                case "Car":
                    textBox3.Enabled = true;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    break;

                case "Plane":
                    textBox3.Enabled = true;
                    textBox4.Enabled = false;
                    textBox5.Enabled = true;
                    break;

                case "Submarine":
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox5.Enabled = false;
                    break;
            }
           
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox4.Text != null)
            {
                if (comboBox4.SelectedItem is IDive)
                {
                    var submarine = (Submarine)comboBox4.SelectedItem;
                    richTextBox1.Text += "Name: " + (submarine.GetName());
                    richTextBox1.Text += "\nPrice: " + (submarine.GetPrice());
                    richTextBox1.Text += "\nAcceleration: " + (submarine.GetAcceleration());
                    richTextBox1.Text += "\nDive: " + (submarine.GetDive());
                   
                }
                else if (comboBox4.SelectedItem is IRise)
                {
                    var plane = (Plane)comboBox4.SelectedItem;
                    richTextBox1.Text += "Name: " + (plane.GetName());
                    richTextBox1.Text += "\nPrice: " + (plane.GetPrice());
                    richTextBox1.Text += "\nAcceleration: " + (plane.GetAcceleration());
                    richTextBox1.Text += "\nRise: " + (plane.GetRise());

                }
                else if (comboBox4.SelectedItem is IAccelerate)
                {
                    var car = (Car)comboBox4.SelectedItem;
                    richTextBox1.Text += "Name: " + (car.GetName());
                    richTextBox1.Text += "\nPrice: " + (car.GetPrice());
                    richTextBox1.Text += "\nAcceleration: " + (car.GetAcceleration());
                }
                else
                {
                    var computer = (Computer)comboBox4.SelectedItem;
                    richTextBox1.Text += "Name: " + (computer.GetName());
                    richTextBox1.Text += "\nPrice: " + (computer.GetPrice());
                }
            }
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string toysName;
            toysName = comboBox5.SelectedItem.ToString();
            //TODO dokończyć wyszukiwanie zabawek po nazwie
            if (comboBox5.SelectedItem is IRise)
            {
                textBox6.Enabled = true;
                textBox7.Enabled = false;
                textBox8.Enabled = true;

                var plane = (Plane)comboBox5.SelectedItem;
                textBox9.Text = plane.GetPrice().ToString();
                textBox6.Text = plane.GetAcceleration().ToString();
                textBox8.Text = plane.GetRise().ToString();
            }
            else if (comboBox5.SelectedItem is IDive)
            {
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = false;

                var submarine = (Submarine)comboBox5.SelectedItem;
                textBox9.Text = submarine.GetPrice().ToString();
                textBox6.Text = submarine.GetAcceleration().ToString();
                textBox7.Text = submarine.GetDive().ToString();
            }
            else if (comboBox5.SelectedItem is IAccelerate)
            {
                textBox6.Enabled = true;
                textBox7.Enabled = false;
                textBox8.Enabled = false;

                var car = (Car)comboBox5.SelectedItem;
                textBox9.Text = car.GetPrice().ToString();
                textBox6.Text = car.GetAcceleration().ToString();
            }
            else
            {
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;

                var computer = (Computer)comboBox5.SelectedItem;
                textBox9.Text = computer.GetPrice().ToString();
            }
        }

        private void comboBox5_Click(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
            comboBox5.ResetText();
            textBox6.ResetText();
            textBox7.ResetText();
            textBox8.ResetText();
            textBox9.ResetText();

            for(int i = 0; i < Toys.Count; i++)
            {
                string toysName;
                if (Toys[i] is IDive)
                {
                    var submarine = (Submarine)Toys[i];
                    toysName = submarine.GetName();

                }
                else if (Toys[i] is IRise)
                {
                    var plane = (Plane)Toys[i];
                    toysName = plane.GetName();

                }
                else if (Toys[i] is IAccelerate)
                {
                    var car = (Car)Toys[i];
                    toysName = car.GetName();
                }
                else
                {
                    var computer = (Computer)Toys[i];
                    toysName = computer.GetName();
                }
                this.comboBox5.Items.Add(toysName);
            }

            
        } 

        private void comboBox4_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            richTextBox1.Clear();
            for(int i = 0; i < Toys.Count; i++)
            {
                comboBox4.Items.AddRange(new object[]
                {
                    Toys[i]});
            }

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem is IRise)
            {
                var plane = (Plane)comboBox5.SelectedItem;
                plane.SetPrice(Convert.ToDouble(textBox9.Text));
                plane.SetAcceleration(Convert.ToDouble(textBox6.Text));
                plane.SetRise(Convert.ToDouble(textBox8.Text));
            }
            else if (comboBox5.SelectedItem is IDive)
            {
                var submarine = (Submarine)comboBox5.SelectedItem;
                submarine.SetPrice(Convert.ToDouble(textBox9.Text));
                submarine.SetAcceleration(Convert.ToDouble(textBox6.Text));
                submarine.SetDive(Convert.ToDouble(textBox7.Text));
            }
            else if (comboBox5.SelectedItem is IAccelerate)
            {
                var car = (Car)comboBox5.SelectedItem;
                car.SetPrice(Convert.ToDouble(textBox9.Text));
                car.SetAcceleration(Convert.ToDouble(textBox6.Text));
            }
            else
            {
                var computer = (Computer)comboBox5.SelectedItem;
                computer.SetPrice(Convert.ToDouble(textBox9.Text));
            }

            textBox6.ResetText();
            textBox7.ResetText();
            textBox8.ResetText();
            textBox9.ResetText();
            textBox5.ResetText();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
