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
      double y = Convert.ToDouble(textBox2.Text);
      double z = Convert.ToDouble(textBox3.Text);
      // Ввод исходных данных в окно результатов
      textBox4.Text = "Результаты работы программы ст. Карпусенко А.В. " + Environment.NewLine;
      textBox4.Text += "При X = " + textBox1.Text + Environment.NewLine;
      textBox4.Text += "При Y = " + textBox2.Text + Environment.NewLine;
      textBox4.Text += "При Z = " + textBox3.Text + Environment.NewLine;
      // Определение номера выбранной функции
      int n = 0;
      if (radioButton2.Checked) n = 1;
      else if (radioButton3.Checked) n = 2;
      // Вычисление U
      double u;
      switch (n)
      {
        case 0:
          if ((z - x) == 0) u = y * Math.Sinh(x) * Math.Sinh(x) + z;
          else if ((z - x) < 0) u = y * Math.Exp(Math.Sinh(x)) - z;
          else u = y * Math.Sin(Math.Sinh(x)) + z;
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 1:
          if ((z - x) == 0) u = y * Math.Cosh(x) * Math.Cosh(x) + z;
          else if ((z - x) < 0) u = y * Math.Exp(Math.Cosh(x)) - z;
          else u = y * Math.Sin(Math.Cosh(x)) + z;
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 2:
          if ((z - x) == 0) u = y * Math.Exp(x) * Math.Exp(x) + z;
          else if ((z - x) < 0) u = y * Math.Exp(Math.Exp(x)) - z;
          else u = y * Math.Sin(Math.Exp(x)) + z;
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        default:
          textBox4.Text += "Решение не найдено" + Environment.NewLine;
          break;
      }
    }
  }
}
