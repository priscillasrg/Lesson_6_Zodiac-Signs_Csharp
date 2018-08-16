namespace Signos
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
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.txbDia = new System.Windows.Forms.TextBox();
            this.txbMes = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblPriscillaRizzardo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(41, 28);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(161, 13);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Informe o dia de nascimento (dd)";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(41, 68);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(170, 13);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Informe o mês de nascimento (mm)";
            // 
            // txbDia
            // 
            this.txbDia.Location = new System.Drawing.Point(64, 44);
            this.txbDia.Name = "txbDia";
            this.txbDia.Size = new System.Drawing.Size(107, 20);
            this.txbDia.TabIndex = 2;
            // 
            // txbMes
            // 
            this.txbMes.Location = new System.Drawing.Point(64, 84);
            this.txbMes.Name = "txbMes";
            this.txbMes.Size = new System.Drawing.Size(107, 20);
            this.txbMes.TabIndex = 3;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(76, 110);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(25, 149);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 5;
            this.lblResposta.Text = "Resposta";
            // 
            // lblPriscillaRizzardo
            // 
            this.lblPriscillaRizzardo.AutoSize = true;
            this.lblPriscillaRizzardo.Location = new System.Drawing.Point(85, 213);
            this.lblPriscillaRizzardo.Name = "lblPriscillaRizzardo";
            this.lblPriscillaRizzardo.Size = new System.Drawing.Size(130, 13);
            this.lblPriscillaRizzardo.TabIndex = 6;
            this.lblPriscillaRizzardo.Text = "Made by Priscilla Rizzardo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(239, 250);
            this.Controls.Add(this.lblPriscillaRizzardo);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txbMes);
            this.Controls.Add(this.txbDia);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Name = "Form1";
            this.Text = "Descubra seu Signo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txbDia;
        private System.Windows.Forms.TextBox txbMes;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblPriscillaRizzardo;
    }
}

