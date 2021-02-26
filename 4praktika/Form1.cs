using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4praktika
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      // Получение исходных данных из TextBox
      double x = Convert.ToDouble(textBox1.Text);
      double y = 0;
      // Ввод исходных данных в окно результатов
      textBox4.Text = "Результаты работы программы ст. Карпусенко А.В. " + Environment.NewLine;
      textBox4.Text += "При X = " + textBox1.Text + Environment.NewLine;
      // Определение номера выбранной функции
      int n = 0;
      if (radioButton2.Checked) n = 1;
      else if (radioButton3.Checked) n = 2;
      // Вычисление U
      double u=0;
      double z = 0;
      switch (n)
      {
        case 0:
          z = Math.Sin(x);
          break;

        case 1:
          z = Math.Cos(x);
          break;

        case 2:
          z = Math.Exp(x);
          break;
      }

      if (x >= 10) u = x;
      else if ((x > 0) && (x < 10)) u = 2 * z + 1;
      else if (x <= 10) u = 0;
      textBox4.Text += "y = " + Convert.ToString(u) + Environment.NewLine;

    }
  }
}
