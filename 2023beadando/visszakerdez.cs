using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace _2023beadando
{
    public partial class visszakerdez : Form
    {
        public static int[] szamlista;
        public static List<int> voltszamok = new List<int>();
        public static Form1 fo;
        public visszakerdez(int[] szamlista, Form1 fo)
        {
            voltszamok = new List<int>();
            visszakerdez.szamlista = szamlista;
            visszakerdez.fo = fo;
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_voltszam(Convert.ToInt32(textBox1.Text)) == 0)
                {
                    listBox1.Items.Add(textBox1.Text);
                    voltszamok.Add(Convert.ToInt32(textBox1.Text));
                    textBox1.Text = "";
                }
            }
            catch
            {

            }
        }
        private int check_voltszam(int szam)
        {
            int db = 0;
            for (int i = 0; i < voltszamok.Count; i++)
            {
                if (voltszamok[i] == szam)
                {
                    db = 1;
                    return db;
                }
            }
            return db;
        }
        private int check(int szam)
        {
            int db = 0;
            for(int i = 0; i<szamlista.Length;i++)
            {
                if(szamlista[i]==szam)
                {
                    db = 1;
                }
            }
            return db;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int jo = 0;
            for(int i = 0; i<listBox1.Items.Count;i++)
            {
                int szam = Convert.ToInt32(listBox1.Items[i]);
                if(check(szam)>0)
                {
                    jo += 1;
                }
            }
            MessageBox.Show("A jó válaszok száma: " + jo);
            fo.Show();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
