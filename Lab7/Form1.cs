using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        private string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CarsList.txt";
        CarBase cars;
        public Form1()
        {
            InitializeComponent();
            cars = new CarBase();
            cars.FillCarsList();
            foreach(var car in cars.CarsList)
            {
                listBox1.Items.Add(car.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string content = "";
            foreach (var car in listBox2.Items)
            {
               content += $"{car}\n";
            }
            File.WriteAllText(filepath, content);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            foreach (var car in cars.CarsList)
            {
                listBox1.Items.Add(car.ToString());
            }
        }
    }
}
