﻿namespace WindowsFormsApp
{
    partial class Form_Mascara
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
            this.Msk_TxtBox = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Conteudo = new System.Windows.Forms.Label();
            this.Lbl_MascaraAtiva = new System.Windows.Forms.Label();
            this.Btn_Hora = new System.Windows.Forms.Button();
            this.Btn_Cep = new System.Windows.Forms.Button();
            this.Btn_Moeda = new System.Windows.Forms.Button();
            this.Btn_Data = new System.Windows.Forms.Button();
            this.Btn_Senha = new System.Windows.Forms.Button();
            this.Btn_Telefone = new System.Windows.Forms.Button();
            this.Btn_VerConteudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msk_TxtBox
            // 
            this.Msk_TxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_TxtBox.Location = new System.Drawing.Point(23, 31);
            this.Msk_TxtBox.Name = "Msk_TxtBox";
            this.Msk_TxtBox.ShortcutsEnabled = false;
            this.Msk_TxtBox.Size = new System.Drawing.Size(258, 26);
            this.Msk_TxtBox.TabIndex = 0;
            this.Msk_TxtBox.ValidatingType = typeof(System.DateTime);
            this.Msk_TxtBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Frm_Mascara_MaskInputRejected);
            // 
            // Lbl_Conteudo
            // 
            this.Lbl_Conteudo.AutoSize = true;
            this.Lbl_Conteudo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Conteudo.Location = new System.Drawing.Point(23, 246);
            this.Lbl_Conteudo.Name = "Lbl_Conteudo";
            this.Lbl_Conteudo.Size = new System.Drawing.Size(0, 19);
            this.Lbl_Conteudo.TabIndex = 1;
            // 
            // Lbl_MascaraAtiva
            // 
            this.Lbl_MascaraAtiva.AutoSize = true;
            this.Lbl_MascaraAtiva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MascaraAtiva.Location = new System.Drawing.Point(23, 75);
            this.Lbl_MascaraAtiva.Name = "Lbl_MascaraAtiva";
            this.Lbl_MascaraAtiva.Size = new System.Drawing.Size(0, 19);
            this.Lbl_MascaraAtiva.TabIndex = 2;
            // 
            // Btn_Hora
            // 
            this.Btn_Hora.Location = new System.Drawing.Point(23, 110);
            this.Btn_Hora.Name = "Btn_Hora";
            this.Btn_Hora.Size = new System.Drawing.Size(82, 37);
            this.Btn_Hora.TabIndex = 3;
            this.Btn_Hora.Text = "HORA";
            this.Btn_Hora.UseVisualStyleBackColor = true;
            this.Btn_Hora.Click += new System.EventHandler(this.Btn_Hora_Click);
            // 
            // Btn_Cep
            // 
            this.Btn_Cep.Location = new System.Drawing.Point(111, 110);
            this.Btn_Cep.Name = "Btn_Cep";
            this.Btn_Cep.Size = new System.Drawing.Size(82, 37);
            this.Btn_Cep.TabIndex = 4;
            this.Btn_Cep.Text = "CEP";
            this.Btn_Cep.UseVisualStyleBackColor = true;
            this.Btn_Cep.Click += new System.EventHandler(this.Btn_Cep_Click);
            // 
            // Btn_Moeda
            // 
            this.Btn_Moeda.Location = new System.Drawing.Point(199, 110);
            this.Btn_Moeda.Name = "Btn_Moeda";
            this.Btn_Moeda.Size = new System.Drawing.Size(82, 37);
            this.Btn_Moeda.TabIndex = 5;
            this.Btn_Moeda.Text = "MOEDA";
            this.Btn_Moeda.UseVisualStyleBackColor = true;
            this.Btn_Moeda.Click += new System.EventHandler(this.Btn_Moeda_Click);
            // 
            // Btn_Data
            // 
            this.Btn_Data.Location = new System.Drawing.Point(23, 153);
            this.Btn_Data.Name = "Btn_Data";
            this.Btn_Data.Size = new System.Drawing.Size(82, 37);
            this.Btn_Data.TabIndex = 6;
            this.Btn_Data.Text = "DATA";
            this.Btn_Data.UseVisualStyleBackColor = true;
            this.Btn_Data.Click += new System.EventHandler(this.Btn_Data_Click);
            // 
            // Btn_Senha
            // 
            this.Btn_Senha.Location = new System.Drawing.Point(111, 153);
            this.Btn_Senha.Name = "Btn_Senha";
            this.Btn_Senha.Size = new System.Drawing.Size(82, 37);
            this.Btn_Senha.TabIndex = 7;
            this.Btn_Senha.Text = "SENHA";
            this.Btn_Senha.UseVisualStyleBackColor = true;
            this.Btn_Senha.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_Telefone
            // 
            this.Btn_Telefone.Location = new System.Drawing.Point(199, 153);
            this.Btn_Telefone.Name = "Btn_Telefone";
            this.Btn_Telefone.Size = new System.Drawing.Size(82, 37);
            this.Btn_Telefone.TabIndex = 8;
            this.Btn_Telefone.Text = "TELEFONE";
            this.Btn_Telefone.UseVisualStyleBackColor = true;
            this.Btn_Telefone.Click += new System.EventHandler(this.Btn_Telefone_Click);
            // 
            // Btn_VerConteudo
            // 
            this.Btn_VerConteudo.Location = new System.Drawing.Point(23, 196);
            this.Btn_VerConteudo.Name = "Btn_VerConteudo";
            this.Btn_VerConteudo.Size = new System.Drawing.Size(258, 37);
            this.Btn_VerConteudo.TabIndex = 9;
            this.Btn_VerConteudo.Text = "VER CONTEÚDO";
            this.Btn_VerConteudo.UseVisualStyleBackColor = true;
            this.Btn_VerConteudo.Click += new System.EventHandler(this.Btn_VerConteudo_Click);
            // 
            // Form_Mascara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 283);
            this.Controls.Add(this.Btn_VerConteudo);
            this.Controls.Add(this.Btn_Telefone);
            this.Controls.Add(this.Btn_Senha);
            this.Controls.Add(this.Btn_Data);
            this.Controls.Add(this.Btn_Moeda);
            this.Controls.Add(this.Btn_Cep);
            this.Controls.Add(this.Btn_Hora);
            this.Controls.Add(this.Lbl_MascaraAtiva);
            this.Controls.Add(this.Lbl_Conteudo);
            this.Controls.Add(this.Msk_TxtBox);
            this.Name = "Form_Mascara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplos de Máscaras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Msk_TxtBox;
        private System.Windows.Forms.Label Lbl_Conteudo;
        private System.Windows.Forms.Label Lbl_MascaraAtiva;
        private System.Windows.Forms.Button Btn_Hora;
        private System.Windows.Forms.Button Btn_Cep;
        private System.Windows.Forms.Button Btn_Moeda;
        private System.Windows.Forms.Button Btn_Data;
        private System.Windows.Forms.Button Btn_Senha;
        private System.Windows.Forms.Button Btn_Telefone;
        private System.Windows.Forms.Button Btn_VerConteudo;
    }
}