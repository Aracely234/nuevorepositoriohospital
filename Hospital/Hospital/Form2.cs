﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form2 : Form
    {
        //Variables para volados y generador de numeros pseudoalatorios

        public static double a;
        public static double c;
        public static double Xo;
        public static double M;
        double n, modulo, m = 0, acumulador = 0, promedio, Zo;

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                Pruebas pruebas = new Pruebas();
                pruebas.lblpromedio2.Text = label6.Text;
                pruebas.lbldisnor.Text = label7.Text;
                pruebas.Show();

            }
            else
            {
                MessageBox.Show("No se pueden realizar las pruebas sin generar los números pseudoaleatorios.");
            }

        }

        double[] random = new double[100000];
        int ad;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnNoPseudoalatorio_Click(object sender, EventArgs e)
        {
            if (tbA.Text == "" || tbC.Text == "" || tbXo.Text == "" || tbM.Text == "" || tbn.Text == "")
            {
                MessageBox.Show("Revise que llenara los campos necesarios");
            }
            double.TryParse(tbA.Text, out a);
            double.TryParse(tbC.Text, out c);
            double.TryParse(tbXo.Text, out Xo);
            double.TryParse(tbM.Text, out M);
            double.TryParse(tbn.Text, out n);
            //generar numeros 
            for (int i = 0; i < n; i++)
            {
                modulo = (a * Xo + c) % M;
                random[i] = modulo / M;
                double redoneado = (Math.Round(random[i], 5));
                ad = dataGridView1.Rows.Add();
                dataGridView1.Rows[ad].Cells[0].Value = (i + 1).ToString();
                dataGridView1.Rows[ad].Cells[1].Value = redoneado.ToString();

                acumulador += random[i];

                m = modulo;
                Xo = m;


            }

            //obtenemos el promedio de los números pseodoaleatorios
            promedio = acumulador / n;
            label6.Text = (Math.Round(promedio, 5)).ToString();

            //obtenemos la distribución normal
            Zo = ((Math.Sqrt(n)) * (promedio - 0.5)) / (Math.Sqrt(0.083333333));
            label7.Text = (Math.Round(Zo, 5)).ToString();
        }
    }
}
