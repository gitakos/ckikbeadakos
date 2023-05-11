
namespace _2023beadando
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.db_gp = new System.Windows.Forms.GroupBox();
            this.kilenc_rb = new System.Windows.Forms.RadioButton();
            this.hat_rb = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ido_gb = new System.Windows.Forms.GroupBox();
            this.husz_mp_rb = new System.Windows.Forms.RadioButton();
            this.tiz_mp_rb = new System.Windows.Forms.RadioButton();
            this.ot_mp_rb = new System.Windows.Forms.RadioButton();
            this.paros_cb = new System.Windows.Forms.CheckBox();
            this.bezar_b = new System.Windows.Forms.Button();
            this.indit_b = new System.Windows.Forms.Button();
            this.szoveg_l = new System.Windows.Forms.Label();
            this.db_gp.SuspendLayout();
            this.ido_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // db_gp
            // 
            this.db_gp.Controls.Add(this.kilenc_rb);
            this.db_gp.Controls.Add(this.hat_rb);
            this.db_gp.Location = new System.Drawing.Point(260, 37);
            this.db_gp.Name = "db_gp";
            this.db_gp.Size = new System.Drawing.Size(200, 55);
            this.db_gp.TabIndex = 0;
            this.db_gp.TabStop = false;
            this.db_gp.Text = "Ennyi szám lesz:";
            // 
            // kilenc_rb
            // 
            this.kilenc_rb.AutoSize = true;
            this.kilenc_rb.Location = new System.Drawing.Point(109, 19);
            this.kilenc_rb.Name = "kilenc_rb";
            this.kilenc_rb.Size = new System.Drawing.Size(31, 17);
            this.kilenc_rb.TabIndex = 1;
            this.kilenc_rb.TabStop = true;
            this.kilenc_rb.Text = "9";
            this.kilenc_rb.UseVisualStyleBackColor = true;
            this.kilenc_rb.CheckedChanged += new System.EventHandler(this.kilenc_rb_CheckedChanged);
            // 
            // hat_rb
            // 
            this.hat_rb.AutoSize = true;
            this.hat_rb.Location = new System.Drawing.Point(7, 20);
            this.hat_rb.Name = "hat_rb";
            this.hat_rb.Size = new System.Drawing.Size(31, 17);
            this.hat_rb.TabIndex = 0;
            this.hat_rb.TabStop = true;
            this.hat_rb.Text = "6";
            this.hat_rb.UseVisualStyleBackColor = true;
            this.hat_rb.CheckedChanged += new System.EventHandler(this.hat_rb_CheckedChanged);
            // 
            // ido_gb
            // 
            this.ido_gb.Controls.Add(this.husz_mp_rb);
            this.ido_gb.Controls.Add(this.tiz_mp_rb);
            this.ido_gb.Controls.Add(this.ot_mp_rb);
            this.ido_gb.Location = new System.Drawing.Point(260, 98);
            this.ido_gb.Name = "ido_gb";
            this.ido_gb.Size = new System.Drawing.Size(200, 100);
            this.ido_gb.TabIndex = 1;
            this.ido_gb.TabStop = false;
            this.ido_gb.Text = "Ennyi ideig látszódjon:";
            // 
            // husz_mp_rb
            // 
            this.husz_mp_rb.AutoSize = true;
            this.husz_mp_rb.Location = new System.Drawing.Point(7, 68);
            this.husz_mp_rb.Name = "husz_mp_rb";
            this.husz_mp_rb.Size = new System.Drawing.Size(54, 17);
            this.husz_mp_rb.TabIndex = 2;
            this.husz_mp_rb.TabStop = true;
            this.husz_mp_rb.Text = "20 mp";
            this.husz_mp_rb.UseVisualStyleBackColor = true;
            this.husz_mp_rb.CheckedChanged += new System.EventHandler(this.husz_mp_rb_CheckedChanged);
            // 
            // tiz_mp_rb
            // 
            this.tiz_mp_rb.AutoSize = true;
            this.tiz_mp_rb.Location = new System.Drawing.Point(7, 44);
            this.tiz_mp_rb.Name = "tiz_mp_rb";
            this.tiz_mp_rb.Size = new System.Drawing.Size(54, 17);
            this.tiz_mp_rb.TabIndex = 1;
            this.tiz_mp_rb.TabStop = true;
            this.tiz_mp_rb.Text = "10 mp";
            this.tiz_mp_rb.UseVisualStyleBackColor = true;
            this.tiz_mp_rb.CheckedChanged += new System.EventHandler(this.tiz_mp_rb_CheckedChanged);
            // 
            // ot_mp_rb
            // 
            this.ot_mp_rb.AutoSize = true;
            this.ot_mp_rb.Location = new System.Drawing.Point(7, 20);
            this.ot_mp_rb.Name = "ot_mp_rb";
            this.ot_mp_rb.Size = new System.Drawing.Size(48, 17);
            this.ot_mp_rb.TabIndex = 0;
            this.ot_mp_rb.TabStop = true;
            this.ot_mp_rb.Text = "5 mp";
            this.ot_mp_rb.UseVisualStyleBackColor = true;
            this.ot_mp_rb.CheckedChanged += new System.EventHandler(this.ot_mp_rb_CheckedChanged);
            // 
            // paros_cb
            // 
            this.paros_cb.AutoSize = true;
            this.paros_cb.Location = new System.Drawing.Point(260, 204);
            this.paros_cb.Name = "paros_cb";
            this.paros_cb.Size = new System.Drawing.Size(153, 17);
            this.paros_cb.TabIndex = 2;
            this.paros_cb.Text = "Csak egyjegyűek legyenek";
            this.paros_cb.UseVisualStyleBackColor = true;
            this.paros_cb.CheckedChanged += new System.EventHandler(this.paros_cb_CheckedChanged);
            // 
            // bezar_b
            // 
            this.bezar_b.Location = new System.Drawing.Point(267, 251);
            this.bezar_b.Name = "bezar_b";
            this.bezar_b.Size = new System.Drawing.Size(75, 23);
            this.bezar_b.TabIndex = 3;
            this.bezar_b.Text = "Bezár";
            this.bezar_b.UseVisualStyleBackColor = true;
            this.bezar_b.Click += new System.EventHandler(this.bezar_b_Click);
            // 
            // indit_b
            // 
            this.indit_b.Location = new System.Drawing.Point(82, 251);
            this.indit_b.Name = "indit_b";
            this.indit_b.Size = new System.Drawing.Size(75, 23);
            this.indit_b.TabIndex = 4;
            this.indit_b.Text = "Indulhat";
            this.indit_b.UseVisualStyleBackColor = true;
            this.indit_b.Click += new System.EventHandler(this.indit_b_Click);
            // 
            // szoveg_l
            // 
            this.szoveg_l.AutoSize = true;
            this.szoveg_l.Location = new System.Drawing.Point(13, 13);
            this.szoveg_l.Name = "szoveg_l";
            this.szoveg_l.Size = new System.Drawing.Size(270, 13);
            this.szoveg_l.TabIndex = 5;
            this.szoveg_l.Text = "Nagyon szép és jó szöveg ami elmagyarázza a dolgokat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 290);
            this.Controls.Add(this.szoveg_l);
            this.Controls.Add(this.indit_b);
            this.Controls.Add(this.bezar_b);
            this.Controls.Add(this.paros_cb);
            this.Controls.Add(this.ido_gb);
            this.Controls.Add(this.db_gp);
            this.Name = "Form1";
            this.Text = "Memória tesztelő feladat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.db_gp.ResumeLayout(false);
            this.db_gp.PerformLayout();
            this.ido_gb.ResumeLayout(false);
            this.ido_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox db_gp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton kilenc_rb;
        private System.Windows.Forms.RadioButton hat_rb;
        private System.Windows.Forms.GroupBox ido_gb;
        private System.Windows.Forms.RadioButton husz_mp_rb;
        private System.Windows.Forms.RadioButton tiz_mp_rb;
        private System.Windows.Forms.RadioButton ot_mp_rb;
        private System.Windows.Forms.CheckBox paros_cb;
        private System.Windows.Forms.Button bezar_b;
        private System.Windows.Forms.Button indit_b;
        private System.Windows.Forms.Label szoveg_l;
    }
}

