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
        List<Car> Cars = new List<Car>();
        List<Computer> Computers = new List<Computer>();
        List<Plane> Planes = new List<Plane>();
        List<Submarine> Submarines = new List<Submarine>();

        public FormMainMenu()
        {
            InitializeComponent();
            
            this.comboBox1.Items.AddRange(new object[] {
                        "Car",
                        "Computer",
                        "Plane",
                        "Submarine"});

            this.comboBox2.Items.AddRange(new object[] {
                        "Car",
                        "Computer",
                        "Plane",
                        "Submarine"});

            this.comboBox3.Items.AddRange(new object[] {
                        "Car",
                        "Computer",
                        "Plane",
                        "Submarine"});

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
                    Computers.Add(computer);
                    break;

                case "Car":
                        Car car = new Car();
                        car.SetName(textBox1.Text);
                        car.SetPrice(Convert.ToDouble(textBox2.Text));
                        car.SetAcceleration(Convert.ToDouble(textBox3.Text));
                    Cars.Add(car);
                    break;

                case "Plane":
                        Plane plane = new Plane();
                        plane.SetName(textBox1.Text);
                        plane.SetPrice(Convert.ToDouble(textBox2.Text));
                        plane.SetAcceleration(Convert.ToDouble(textBox3.Text));
                        plane.SetRise(Convert.ToDouble(textBox5.Text));
                    Planes.Add(plane);

                    break;

                case "Submarine":
                        Submarine submarine = new Submarine();
                        submarine.SetName(textBox1.Text);
                        submarine.SetPrice(Convert.ToDouble(textBox2.Text));
                        submarine.SetAcceleration(Convert.ToDouble(textBox3.Text));
                        submarine.SetDive(Convert.ToDouble(textBox4.Text));
                    Submarines.Add(submarine);
                    break; 
            }
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox4.Text != null)
            {
                switch (comboBox3.Text)
                {
                    case "Computer":
                        for (int i = 0; i < Computers.Count; i++)
                        {
                            if (Computers[i].GetName().Equals(comboBox4.Text))
                            {
                                richTextBox1.Text += "Name: " + (Computers[i].GetName());
                                richTextBox1.Text += "\nPrice: " + (Computers[i].GetPrice());
                            }
                        }
                        break;

                    case "Car":
                        for (int i = 0; i < Cars.Count; i++)
                        {
                            if (Cars[i].GetName().Equals(comboBox4.Text))
                            {
                                richTextBox1.Text += "Name: " + (Cars[i].GetName());
                                richTextBox1.Text += "\nPrice: " + (Cars[i].GetPrice());
                                richTextBox1.Text += "\nAcceleration: " + (Cars[i].GetAcceleration());
                            }
                        }
                        break;

                    case "Plane":
                        for (int i = 0; i < Planes.Count; i++)
                        {
                            if (Planes[i].GetName().Equals(comboBox4.Text))
                            {
                                richTextBox1.Text += "Name: " + (Planes[i].GetName());
                                richTextBox1.Text += "\nPrice: " + (Planes[i].GetPrice());
                                richTextBox1.Text += "\nAcceleration: " + (Planes[i].GetAcceleration());
                                richTextBox1.Text += "\nRise: " + (Planes[i].GetRise());
                            }
                        }
                        break;

                    case "Submarine":
                        for (int i = 0; i < Submarines.Count; i++)
                        {
                            if (Submarines[i].GetName().Equals(comboBox4.Text))
                            {
                                richTextBox1.Text += "Name: " + (Submarines[i].GetName());
                                richTextBox1.Text += "\nPrice: " + (Submarines[i].GetPrice());
                                richTextBox1.Text += "\nAcceleration: " + (Submarines[i].GetAcceleration());
                                richTextBox1.Text += "\nDive: " + (Submarines[i].GetDive());
                            }
                        }
                        break;

                    default:
                        break;
                }
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Computer":
                    textBox6.Enabled = false;
                    textBox7.Enabled = false;
                    textBox8.Enabled = false;
                    break;

                case "Car":
                    textBox6.Enabled = true;
                    textBox7.Enabled = false;
                    textBox8.Enabled = false;
                    break;

                case "Plane":
                    textBox6.Enabled = true;
                    textBox7.Enabled = false;
                    textBox8.Enabled = true;
                    break;

                case "Submarine":
                    textBox6.Enabled = true;
                    textBox7.Enabled = true;
                    textBox8.Enabled = false;
                    break;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Computer":
                    for (int i = 0; i < Computers.Count; i++)
                    {
                        if (Computers[i].GetName().Equals(comboBox5.Text))
                        {
                            this.textBox9.Text = Computers[i].GetPrice().ToString();
                            break;
                        }
                    }

                    break;

                case "Car":
                    for (int i = 0; i < Cars.Count; i++)
                    {
                        if (Cars[i].GetName().Equals(comboBox5.Text))
                        {
                            this.textBox9.Text = Cars[i].GetPrice().ToString();
                            this.textBox6.Text = Cars[i].GetAcceleration().ToString();
                            break;
                        }
                    }
                    break;

                case "Plane":
                    for (int i = 0; i < Planes.Count; i++)
                    {
                        if (Planes[i].GetName().Equals(comboBox5.Text))
                        {
                            this.textBox9.Text = Planes[i].GetPrice().ToString();
                            this.textBox6.Text = Planes[i].GetAcceleration().ToString();
                            this.textBox8.Text = Planes[i].GetRise().ToString();
                            break;
                        }
                    }

                    break;

                case "Submarine":
                    for (int i = 0; i < Submarines.Count; i++)
                    {
                        if (Submarines[i].GetName().Equals(comboBox5.Text))
                        {
                            this.textBox9.Text = Submarines[i].GetPrice().ToString();
                            this.textBox6.Text = Submarines[i].GetAcceleration().ToString();
                            this.textBox7.Text = Submarines[i].GetDive().ToString();
                            break;
                        }
                    }
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_Click(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
            comboBox5.ResetText();
            textBox6.ResetText();
            textBox7.ResetText();
            textBox8.ResetText();
            textBox9.ResetText();

            switch (comboBox2.Text)
            {
                case "Computer":

                    for (int i = 0; i < Computers.Count; i++)
                    {
                        this.comboBox5.Items.Add(Computers[i].GetName());
                    }
                    break;

                case "Car":
                    for (int i = 0; i < Cars.Count; i++)
                    {
                        this.comboBox5.Items.Add(Cars[i].GetName());
                    }

                    break;

                case "Plane":
                    for (int i = 0; i < Planes.Count; i++)
                    {
                        this.comboBox5.Items.Add(Planes[i].GetName());
                    }

                    break;

                case "Submarine":
                    for (int i = 0; i < Submarines.Count; i++)
                    {
                        this.comboBox5.Items.Add(Submarines[i].GetName());
                    }

                    break;
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            comboBox4.ResetText();
            richTextBox1.ResetText();

            switch (comboBox3.Text)
            {
                case "Computer":

                    for (int i = 0; i < Computers.Count; i++)
                    {
                        this.comboBox5.Items.Add(Computers[i].GetName());
                    }
                    break;

                case "Car":
                    for (int i = 0; i < Cars.Count; i++)
                    {
                        this.comboBox5.Items.Add(Cars[i].GetName());
                    }

                    break;

                case "Plane":
                    for (int i = 0; i < Planes.Count; i++)
                    {
                        this.comboBox5.Items.Add(Planes[i].GetName());
                    }

                    break;

                case "Submarine":
                    for (int i = 0; i < Submarines.Count; i++)
                    {
                        this.comboBox5.Items.Add(Submarines[i].GetName());
                    }

                    break;
            }
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            comboBox4.ResetText();

            switch (comboBox3.Text)
            {
                case "Computer":

                    for (int i = 0; i < Computers.Count; i++)
                    {
                        this.comboBox4.Items.Add(Computers[i].GetName());
                    }
                    break;

                case "Car":
                    for (int i = 0; i < Cars.Count; i++)
                    {
                        this.comboBox4.Items.Add(Cars[i].GetName());
                    }

                    break;

                case "Plane":
                    for (int i = 0; i < Planes.Count; i++)
                    {
                        this.comboBox4.Items.Add(Planes[i].GetName());
                    }

                    break;

                case "Submarine":
                    for (int i = 0; i < Submarines.Count; i++)
                    {
                        this.comboBox4.Items.Add(Submarines[i].GetName());
                    }

                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Computer":
                    for(int i = 0; i < Computers.Count; i++)
                    {
                        if (Computers[i].GetName().Equals(comboBox5.Text))
                        {
                            Computers[i].SetPrice(Convert.ToDouble(textBox9.Text));
                            break;
                        }
                    }
                    
                    break;

                case "Car":
                    for (int i = 0; i < Cars.Count; i++)
                    {
                        if (Cars[i].GetName().Equals(comboBox5.Text))
                        {
                            Cars[i].SetPrice(Convert.ToDouble(textBox9.Text));
                            Cars[i].SetAcceleration(Convert.ToDouble(textBox6.Text));
                            break;
                        }
                    }
                    break;

                case "Plane":
                    for (int i = 0; i < Planes.Count; i++)
                    {
                        if (Planes[i].GetName().Equals(comboBox5.Text))
                        {
                            Planes[i].SetPrice(Convert.ToDouble(textBox9.Text));
                            Planes[i].SetAcceleration(Convert.ToDouble(textBox6.Text));
                            Planes[i].SetRise(Convert.ToDouble(textBox8.Text));
                            break;
                        }
                    }

                    break;

                case "Submarine":
                    for (int i = 0; i < Submarines.Count; i++)
                    {
                        if (Submarines[i].GetName().Equals(comboBox5.Text))
                        {
                            Submarines[i].SetPrice(Convert.ToDouble(textBox9.Text));
                            Submarines[i].SetAcceleration(Convert.ToDouble(textBox6.Text));
                            Submarines[i].SetDive(Convert.ToDouble(textBox7.Text));
                            break;
                        }
                    }
                    break;
            }
            textBox6.ResetText();
            textBox7.ResetText();
            textBox8.ResetText();
            textBox9.ResetText();
            textBox5.ResetText();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
