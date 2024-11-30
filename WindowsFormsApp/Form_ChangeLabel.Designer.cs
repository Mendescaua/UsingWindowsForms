namespace WindowsFormsApp
{
    partial class Form_ChangeLabel
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
            this.Lbl_Show = new System.Windows.Forms.Label();
            this.Btn_MudarLabel = new System.Windows.Forms.Button();
            this.Txt_Write = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Show
            // 
            this.Lbl_Show.AutoSize = true;
            this.Lbl_Show.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Show.Location = new System.Drawing.Point(12, 20);
            this.Lbl_Show.Name = "Lbl_Show";
            this.Lbl_Show.Size = new System.Drawing.Size(210, 23);
            this.Lbl_Show.TabIndex = 0;
            this.Lbl_Show.Text = "Input dolor colum pixel";
            // 
            // Btn_MudarLabel
            // 
            this.Btn_MudarLabel.Location = new System.Drawing.Point(12, 156);
            this.Btn_MudarLabel.Name = "Btn_MudarLabel";
            this.Btn_MudarLabel.Size = new System.Drawing.Size(359, 36);
            this.Btn_MudarLabel.TabIndex = 1;
            this.Btn_MudarLabel.Text = "Mudar Label";
            this.Btn_MudarLabel.UseVisualStyleBackColor = true;
            this.Btn_MudarLabel.Click += new System.EventHandler(this.Btn_MudarLabel_Click);
            // 
            // Txt_Write
            // 
            this.Txt_Write.Location = new System.Drawing.Point(12, 58);
            this.Txt_Write.Multiline = true;
            this.Txt_Write.Name = "Txt_Write";
            this.Txt_Write.Size = new System.Drawing.Size(359, 92);
            this.Txt_Write.TabIndex = 2;
            this.Txt_Write.TextChanged += new System.EventHandler(this.Txt_Write_TextChanged);
            // 
            // Form_ChangeLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 204);
            this.Controls.Add(this.Txt_Write);
            this.Controls.Add(this.Btn_MudarLabel);
            this.Controls.Add(this.Lbl_Show);
            this.Name = "Form_ChangeLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mudar o Label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Show;
        private System.Windows.Forms.Button Btn_MudarLabel;
        private System.Windows.Forms.TextBox Txt_Write;
    }
}