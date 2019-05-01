namespace TripleDES
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
            System.Windows.Forms.Button btnEnkripto;
            System.Windows.Forms.Button btnDekripto;
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblZgjedhFajllin = new System.Windows.Forms.Label();
            this.txtFajlli = new System.Windows.Forms.TextBox();
            this.btnZgjedh = new System.Windows.Forms.Button();
            this.btnEnkript = new System.Windows.Forms.Button();
            this.chAutoKey = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkey = new System.Windows.Forms.TextBox();
            btnEnkripto = new System.Windows.Forms.Button();
            btnDekripto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnkripto
            // 
            btnEnkripto.Location = new System.Drawing.Point(116, 96);
            btnEnkripto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnEnkripto.Name = "btnEnkripto";
            btnEnkripto.Size = new System.Drawing.Size(145, 48);
            btnEnkripto.TabIndex = 0;
            btnEnkripto.Text = "Enkripto";
            btnEnkripto.UseVisualStyleBackColor = true;
            btnEnkripto.Click += new System.EventHandler(this.btnEnkripto_Click);
            // 
            // btnDekripto
            // 
            btnDekripto.Location = new System.Drawing.Point(116, 220);
            btnDekripto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDekripto.Name = "btnDekripto";
            btnDekripto.Size = new System.Drawing.Size(145, 48);
            btnDekripto.TabIndex = 6;
            btnDekripto.Text = "Dekripto";
            btnDekripto.UseVisualStyleBackColor = true;
            btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teksti";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 171);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(393, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enkriptimi";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 295);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(393, 22);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dekriptimi";
            // 
            // lblZgjedhFajllin
            // 
            this.lblZgjedhFajllin.AutoSize = true;
            this.lblZgjedhFajllin.Location = new System.Drawing.Point(539, 21);
            this.lblZgjedhFajllin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZgjedhFajllin.Name = "lblZgjedhFajllin";
            this.lblZgjedhFajllin.Size = new System.Drawing.Size(92, 17);
            this.lblZgjedhFajllin.TabIndex = 32;
            this.lblZgjedhFajllin.Text = "Zgjedh fajllin:";
            // 
            // txtFajlli
            // 
            this.txtFajlli.Location = new System.Drawing.Point(542, 42);
            this.txtFajlli.Margin = new System.Windows.Forms.Padding(4);
            this.txtFajlli.Name = "txtFajlli";
            this.txtFajlli.ReadOnly = true;
            this.txtFajlli.Size = new System.Drawing.Size(288, 22);
            this.txtFajlli.TabIndex = 30;
            // 
            // btnZgjedh
            // 
            this.btnZgjedh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZgjedh.Location = new System.Drawing.Point(838, 42);
            this.btnZgjedh.Margin = new System.Windows.Forms.Padding(4);
            this.btnZgjedh.Name = "btnZgjedh";
            this.btnZgjedh.Size = new System.Drawing.Size(87, 22);
            this.btnZgjedh.TabIndex = 31;
            this.btnZgjedh.Text = "...";
            this.btnZgjedh.UseVisualStyleBackColor = true;
            this.btnZgjedh.Click += new System.EventHandler(this.btnZgjedh_Click);
            // 
            // btnEnkript
            // 
            this.btnEnkript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnkript.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnkript.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnEnkript.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnkript.Location = new System.Drawing.Point(542, 220);
            this.btnEnkript.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnkript.Name = "btnEnkript";
            this.btnEnkript.Size = new System.Drawing.Size(131, 42);
            this.btnEnkript.TabIndex = 33;
            this.btnEnkript.Text = "EnkriptoFile";
            this.btnEnkript.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnkript.UseVisualStyleBackColor = true;
            this.btnEnkript.Click += new System.EventHandler(this.btnEnkript_Click);
            // 
            // chAutoKey
            // 
            this.chAutoKey.AutoSize = true;
            this.chAutoKey.Location = new System.Drawing.Point(838, 171);
            this.chAutoKey.Margin = new System.Windows.Forms.Padding(4);
            this.chAutoKey.Name = "chAutoKey";
            this.chAutoKey.Size = new System.Drawing.Size(83, 21);
            this.chAutoKey.TabIndex = 36;
            this.chAutoKey.Text = "AutoKey";
            this.chAutoKey.UseVisualStyleBackColor = true;
            this.chAutoKey.CheckedChanged += new System.EventHandler(this.chAutoKey_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Key:";
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(542, 171);
            this.txtkey.Margin = new System.Windows.Forms.Padding(4);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(288, 22);
            this.txtkey.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 352);
            this.Controls.Add(this.chAutoKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.btnEnkript);
            this.Controls.Add(this.lblZgjedhFajllin);
            this.Controls.Add(this.txtFajlli);
            this.Controls.Add(this.btnZgjedh);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(btnDekripto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(btnEnkripto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblZgjedhFajllin;
        private System.Windows.Forms.TextBox txtFajlli;
        private System.Windows.Forms.Button btnZgjedh;
        private System.Windows.Forms.Button btnEnkript;
        private System.Windows.Forms.CheckBox chAutoKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkey;
    }
}

