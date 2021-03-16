﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_praktika
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      dataGridView1.RowCount = 15; //Указываем количество строк
      dataGridView1.ColumnCount = 15; //Указываем количество столбцов
      int[,] a = new int[15, 15]; //Инициализируем массив
      int i, j;
      //Заполняем матрицу случайными числами
      Random rand = new Random();
      for (i = 0; i < 15; i++)
        for (j = 0; j < 15; j++)
          a[i, j] = rand.Next(-100, 100);
      //Выводим матрицу в dataGridView1
      for (i = 0; i < 15; i++)
        for (j = 0; j < 15; j++)
          dataGridView1.Rows[i].Cells[j].Value =
         Convert.ToString(a[i, j]);
      //производим поиск максимального элемента на дополнительной диагонали
 int m = int.MaxValue;
      for (i = 0; i < 15; i++)
        if (a[i, 14 - i] > m) m = a[i, 14 - i];
      // выводим результат
      textBox1.Text = Convert.ToString(m);
    }
  }
}
