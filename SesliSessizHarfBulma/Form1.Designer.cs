namespace SesliSessizHarfBulma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rchText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnSessizHarf = new System.Windows.Forms.Button();
            this.btnSesliHarf = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchText
            // 
            this.rchText.Location = new System.Drawing.Point(12, 18);
            this.rchText.Name = "rchText";
            this.rchText.Size = new System.Drawing.Size(881, 161);
            this.rchText.TabIndex = 0;
            this.rchText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(418, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sonuc:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(12, 225);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(881, 62);
            this.txtSonuc.TabIndex = 3;
            this.txtSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSessizHarf
            // 
            this.btnSessizHarf.BackColor = System.Drawing.Color.White;
            this.btnSessizHarf.Location = new System.Drawing.Point(457, 314);
            this.btnSessizHarf.Name = "btnSessizHarf";
            this.btnSessizHarf.Size = new System.Drawing.Size(436, 121);
            this.btnSessizHarf.TabIndex = 4;
            this.btnSessizHarf.Text = "Sessiz Harf Getir";
            this.btnSessizHarf.UseVisualStyleBackColor = false;
            this.btnSessizHarf.Click += new System.EventHandler(this.btnSessizHarf_Click);
            // 
            // btnSesliHarf
            // 
            this.btnSesliHarf.BackColor = System.Drawing.Color.White;
            this.btnSesliHarf.Location = new System.Drawing.Point(12, 314);
            this.btnSesliHarf.Name = "btnSesliHarf";
            this.btnSesliHarf.Size = new System.Drawing.Size(439, 121);
            this.btnSesliHarf.TabIndex = 4;
            this.btnSesliHarf.Text = "Sesli Harfleri Getir";
            this.btnSesliHarf.UseVisualStyleBackColor = false;
            this.btnSesliHarf.Click += new System.EventHandler(this.btnSesliHarf_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTemizle.Location = new System.Drawing.Point(12, 441);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(881, 124);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(905, 588);
            this.Controls.Add(this.btnSesliHarf);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSessizHarf);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchText);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesli Sessiz Harf Bulma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rchText;
        private Label label1;
        private TextBox txtSonuc;
        private Button btnSessizHarf;
        private Button btnSesliHarf;
        private Button btnTemizle;
    }
}