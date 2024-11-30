namespace WindowsFormsApp
{
    partial class Form_Home
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
            this.Btn_KeyValue = new System.Windows.Forms.Button();
            this.Btn_Mascara = new System.Windows.Forms.Button();
            this.Btn_ValidaSenha = new System.Windows.Forms.Button();
            this.Btn_ValidaCpf = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_Detk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_KeyValue
            // 
            this.Btn_KeyValue.Location = new System.Drawing.Point(251, 12);
            this.Btn_KeyValue.Name = "Btn_KeyValue";
            this.Btn_KeyValue.Size = new System.Drawing.Size(114, 48);
            this.Btn_KeyValue.TabIndex = 0;
            this.Btn_KeyValue.Text = "KeyValue";
            this.Btn_KeyValue.UseVisualStyleBackColor = true;
            this.Btn_KeyValue.Click += new System.EventHandler(this.Btn_KeyValue_Click);
            // 
            // Btn_Mascara
            // 
            this.Btn_Mascara.Location = new System.Drawing.Point(132, 12);
            this.Btn_Mascara.Name = "Btn_Mascara";
            this.Btn_Mascara.Size = new System.Drawing.Size(114, 48);
            this.Btn_Mascara.TabIndex = 1;
            this.Btn_Mascara.Text = "Mascara";
            this.Btn_Mascara.UseVisualStyleBackColor = true;
            this.Btn_Mascara.Click += new System.EventHandler(this.Btn_Mascara_Click);
            // 
            // Btn_ValidaSenha
            // 
            this.Btn_ValidaSenha.Location = new System.Drawing.Point(132, 66);
            this.Btn_ValidaSenha.Name = "Btn_ValidaSenha";
            this.Btn_ValidaSenha.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaSenha.TabIndex = 2;
            this.Btn_ValidaSenha.Text = "Validar Senha";
            this.Btn_ValidaSenha.UseVisualStyleBackColor = true;
            this.Btn_ValidaSenha.Click += new System.EventHandler(this.Btn_ValidaSenha_Click);
            // 
            // Btn_ValidaCpf
            // 
            this.Btn_ValidaCpf.Location = new System.Drawing.Point(12, 66);
            this.Btn_ValidaCpf.Name = "Btn_ValidaCpf";
            this.Btn_ValidaCpf.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaCpf.TabIndex = 3;
            this.Btn_ValidaCpf.Text = "Validar Cpf";
            this.Btn_ValidaCpf.UseVisualStyleBackColor = true;
            this.Btn_ValidaCpf.Click += new System.EventHandler(this.Btn_ValidaCpf_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "Mudar Label";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Detk
            // 
            this.Btn_Detk.Location = new System.Drawing.Point(251, 66);
            this.Btn_Detk.Name = "Btn_Detk";
            this.Btn_Detk.Size = new System.Drawing.Size(114, 48);
            this.Btn_Detk.TabIndex = 4;
            this.Btn_Detk.Text = "Detk";
            this.Btn_Detk.UseVisualStyleBackColor = true;
            this.Btn_Detk.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 126);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Detk);
            this.Controls.Add(this.Btn_ValidaCpf);
            this.Controls.Add(this.Btn_ValidaSenha);
            this.Controls.Add(this.Btn_Mascara);
            this.Controls.Add(this.Btn_KeyValue);
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_KeyValue;
        private System.Windows.Forms.Button Btn_Mascara;
        private System.Windows.Forms.Button Btn_ValidaSenha;
        private System.Windows.Forms.Button Btn_ValidaCpf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_Detk;
    }
}