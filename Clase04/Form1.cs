using Microsoft.VisualBasic;
using System.Linq;

namespace Clase04
{
    public partial class Form1 : Form
    {
        List<string> nombres = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombres.Add(textBox1.Text);
            label1.Text = "Dato Agregado";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            //label1.Text = string.Join(", ", nombres);

            nombres.ForEach(nombre => label1.Text += nombre);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = nombres.FindIndex(name => name == label1.Text);
            nombres[index] = textBox1.Text;
            label1.Text = "Dato Actualizado";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (string nombre in nombres)
            {
                if (nombre == textBox1.Text)
                {
                    label1.Text = nombre;
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nombres.Remove(textBox1.Text);
            label1.Text = "Dato Removido";
        }
    }
}