using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int variable = int.Parse(textBox1.Text);
            StreamWriter flujosalida = File.CreateText(@"C:\Users\aguil\Documents\archivo.txt");
            flujosalida.WriteLine("Uriel");
            flujosalida.WriteLine("Aguilar");
            flujosalida.WriteLine("Mauricio");

            for (int lineas = 1; lineas <= 10; lineas++)
            {
                for (int estrellas = 1; estrellas <= lineas; estrellas++)
                {
                    flujosalida.Write("*");
                }
                flujosalida.WriteLine();
            }
            for (int fila = 0; fila < variable; fila++)
            {
                for (int columna = 0; columna < variable; columna++)
                {
                    flujosalida.Write(" * ");
                }
                flujosalida.WriteLine();
            }
            flujosalida.Close();

            MessageBox.Show("Se ha creado el archivo");

        }
    }
}
