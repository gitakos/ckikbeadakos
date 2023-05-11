using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023beadando
{
    public partial class jatekterkilenc : Form
    {
        public static bool egyjegyu;
        public static int[] lista;
        public jatekterkilenc(bool egyjegyu)
        {
            jatekterkilenc.egyjegyu = egyjegyu;
            InitializeComponent();
        }
        private int[] randGen(int hossz, bool egyjegyu)
        {
            int[] gen = new int[hossz];
            Random r = new Random();
            if (egyjegyu == false)
            {
                for (int i = 0; i < hossz; i++)
                {
                    int rand = r.Next(10, 100);
                    while (gen.Contains(rand))
                    {
                        rand = r.Next(10, 100);
                    }
                    gen[i] = rand;
                }
            }
            else
            {
                for (int i = 0; i < hossz; i++)
                {
                    int rand = r.Next(0, 10);
                    while (gen.Contains(rand))
                    {
                        rand = r.Next(0, 10);
                    }
                    gen[i] = rand;
                }
            }
            return gen;
        }
        private void jatekterkilenc_Load(object sender, EventArgs e)
        {
            lista = randGen(9, egyjegyu);
            button1.Text = Convert.ToString(lista[0]);
            button2.Text = Convert.ToString(lista[1]);
            button3.Text = Convert.ToString(lista[2]);
            button4.Text = Convert.ToString(lista[3]);
            button5.Text = Convert.ToString(lista[4]);
            button6.Text = Convert.ToString(lista[5]);
            button7.Text = Convert.ToString(lista[6]);
            button8.Text = Convert.ToString(lista[7]);
            button9.Text = Convert.ToString(lista[8]);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
