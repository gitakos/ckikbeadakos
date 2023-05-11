using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023beadando
{
    public partial class Form1 : Form
    {
        public static int kivalaszott;
        public static int kivalaszottido;
        public static bool egyjegyue = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hat_rb.Checked = true;
            kivalaszott = 6;
            ot_mp_rb.Checked = true;
            kivalaszottido = 5;
        }

        private void hat_rb_CheckedChanged(object sender, EventArgs e)
        {
            husz_mp_rb.Enabled = false;
            ot_mp_rb.Enabled = true;
            kivalaszott = 6;
            if (husz_mp_rb.Checked == true)
            {
                husz_mp_rb.Checked = false;
                ot_mp_rb.Checked = true;
                kivalaszottido = 5;
            }
        }

        private void kilenc_rb_CheckedChanged(object sender, EventArgs e)
        {
            ot_mp_rb.Enabled = false;
            husz_mp_rb.Enabled = true;
            kivalaszott = 9;
            if (ot_mp_rb.Checked == true)
            {
                ot_mp_rb.Checked = false;
                tiz_mp_rb.Checked = true;
                kivalaszottido = 10;
            }
        }

        private void indit_b_Click(object sender, EventArgs e)
        {
            Hide();
            if (kivalaszott == 6)
            {
                jatekter jatek = new jatekter(egyjegyue);
                jatek.Show();
                var t = Task.Run(async delegate
                {
                    await Task.Delay(kivalaszottido * 1000);
                });
                t.Wait();
                jatek.Close();
                visszakerdez vissza = new visszakerdez(jatekter.lista, this);
                vissza.Show();
            }
            else
            {
                jatekterkilenc jatek = new jatekterkilenc(egyjegyue);
                jatek.Show();
                var t = Task.Run(async delegate
                {
                    await Task.Delay(kivalaszottido * 1000);
                });
                t.Wait();
                jatek.Close();
                visszakerdez vissza = new visszakerdez(jatekterkilenc.lista,this);
                vissza.Show();
            }
        }

        private void ot_mp_rb_CheckedChanged(object sender, EventArgs e)
        {
            if(ot_mp_rb.Checked == true)
            {
                kivalaszottido = 5;
            }
        }

        private void tiz_mp_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (tiz_mp_rb.Checked == true)
            {
                kivalaszottido = 10;
            }
        }

        private void husz_mp_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (husz_mp_rb.Checked == true)
            {
                kivalaszottido = 20;
            }
        }

        private void paros_cb_CheckedChanged(object sender, EventArgs e)
        {
            egyjegyue = paros_cb.Checked;
        }

        private void bezar_b_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
