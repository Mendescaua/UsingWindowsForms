namespace WindowsFormsApp
{
    partial class KeyValue
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
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.lbl_Maius = new System.Windows.Forms.Label();
            this.lbl_minus = new System.Windows.Forms.Label();
            this.lbl_Ma = new System.Windows.Forms.Label();
            this.lbl_Mi = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(12, 16);
            this.txt_1.Multiline = true;
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(114, 27);
            this.txt_1.TabIndex = 0;
            this.txt_1.TextChanged += new System.EventHandler(this.txt_1_TextChanged);
            this.txt_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_1_KeyDown);
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(12, 54);
            this.txt_2.Multiline = true;
            this.txt_2.Name = "txt_2";
            this.txt_2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_2.Size = new System.Drawing.Size(304, 232);
            this.txt_2.TabIndex = 1;
            this.txt_2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_Maius
            // 
            this.lbl_Maius.AutoSize = true;
            this.lbl_Maius.Location = new System.Drawing.Point(322, 63);
            this.lbl_Maius.Name = "lbl_Maius";
            this.lbl_Maius.Size = new System.Drawing.Size(38, 13);
            this.lbl_Maius.TabIndex = 2;
            this.lbl_Maius.Text = "Maius.";
            this.lbl_Maius.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_minus
            // 
            this.lbl_minus.AutoSize = true;
            this.lbl_minus.Location = new System.Drawing.Point(322, 108);
            this.lbl_minus.Name = "lbl_minus";
            this.lbl_minus.Size = new System.Drawing.Size(38, 13);
            this.lbl_minus.TabIndex = 3;
            this.lbl_minus.Text = "Minus.";
            // 
            // lbl_Ma
            // 
            this.lbl_Ma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Ma.Location = new System.Drawing.Point(375, 58);
            this.lbl_Ma.Name = "lbl_Ma";
            this.lbl_Ma.Size = new System.Drawing.Size(50, 30);
            this.lbl_Ma.TabIndex = 4;
            this.lbl_Ma.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_Mi
            // 
            this.lbl_Mi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Mi.Location = new System.Drawing.Point(375, 107);
            this.lbl_Mi.Name = "lbl_Mi";
            this.lbl_Mi.Size = new System.Drawing.Size(50, 30);
            this.lbl_Mi.TabIndex = 5;
            this.lbl_Mi.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(350, 16);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 27);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Limpar";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // KeyValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 298);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_Mi);
            this.Controls.Add(this.lbl_Ma);
            this.Controls.Add(this.lbl_minus);
            this.Controls.Add(this.lbl_Maius);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Name = "KeyValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyValue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Label lbl_Maius;
        private System.Windows.Forms.Label lbl_minus;
        private System.Windows.Forms.Label lbl_Ma;
        private System.Windows.Forms.Label lbl_Mi;
        private System.Windows.Forms.Button btn_Clear;
    }
}