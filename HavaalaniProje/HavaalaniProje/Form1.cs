using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavaalaniProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add ( "Sayın "+ isimtxt.Text+ " Biletiniz; " + dateTimePicker1 +" Tarihinde " +
          " Saat "  + comboBox3.SelectedItem +  comboBox1.SelectedItem +  " - "  + comboBox2.SelectedItem +   
          "  olarak belirlenmiştir. "+" Yolculuk bilgileriniz " + textBox1.Text +
          " No'lu telefon numaranıza iletilecektir. İyi Yolculuklar Dileriz.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
