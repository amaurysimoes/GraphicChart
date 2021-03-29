using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://www.youtube.com/watch?v=gqo2TGpCOlA&t=377s
//https://www.youtube.com/watch?v=yHtRlJCv4j8 - forma mais simples

namespace Grafic_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chart1.Titles.Add("Pie Chart");

            chart1.Series["S1"].Points.AddXY("1", "33");
            chart1.Series["S1"].Points.AddXY("2", "34");
            chart1.Series["S1"].Points.AddXY("1", "35");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Robo_grafico - nome do grafico
            //Textbox para o gráfico: de 1 a textBox5

            chart_Robo.Titles.Add("Pie Chart");

            chart_Robo.Series["Robo_grafico"].Points.AddXY("TOTAL PLANEJADO", textBox1.Text);
            chart_Robo.Series["Robo_grafico"].Points.AddXY("TOTAL PRODUZIDO", textBox2.Text);
            chart_Robo.Series["Robo_grafico"].Points.AddXY("FALHAS DE PROCESSO", textBox3.Text);
            chart_Robo.Series["Robo_grafico"].Points.AddXY("APROVADOS", textBox4.Text);
            chart_Robo.Series["Robo_grafico"].Points.AddXY("OUTROS DEFEITOS", textBox5.Text);


        }
    }
}
