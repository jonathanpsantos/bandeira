
namespace aula03
{
    partial class FormCobinacoes
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
            this.chkRetangulo = new System.Windows.Forms.CheckBox();
            this.chkLosango = new System.Windows.Forms.CheckBox();
            this.labelTexto = new System.Windows.Forms.Label();
            this.pictureBoxFormas = new System.Windows.Forms.PictureBox();
            this.chkCirculo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormas)).BeginInit();
            this.SuspendLayout();
            // 
            // chkRetangulo
            // 
            this.chkRetangulo.AutoSize = true;
            this.chkRetangulo.Location = new System.Drawing.Point(55, 99);
            this.chkRetangulo.Name = "chkRetangulo";
            this.chkRetangulo.Size = new System.Drawing.Size(75, 17);
            this.chkRetangulo.TabIndex = 0;
            this.chkRetangulo.Text = "Retângulo";
            this.chkRetangulo.UseVisualStyleBackColor = true;
            this.chkRetangulo.CheckedChanged += new System.EventHandler(this.chkRetangulo_CheckedChanged);
            // 
            // chkLosango
            // 
            this.chkLosango.AutoSize = true;
            this.chkLosango.Location = new System.Drawing.Point(55, 151);
            this.chkLosango.Name = "chkLosango";
            this.chkLosango.Size = new System.Drawing.Size(67, 17);
            this.chkLosango.TabIndex = 1;
            this.chkLosango.Text = "Losango";
            this.chkLosango.UseVisualStyleBackColor = true;
            this.chkLosango.CheckedChanged += new System.EventHandler(this.chkLosango_CheckedChanged);
            // 
            // labelTexto
            // 
            this.labelTexto.Location = new System.Drawing.Point(356, 56);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(418, 25);
            this.labelTexto.TabIndex = 4;
            this.labelTexto.Text = "Forma desconhecida";
            this.labelTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxFormas
            // 
            this.pictureBoxFormas.Location = new System.Drawing.Point(356, 110);
            this.pictureBoxFormas.Name = "pictureBoxFormas";
            this.pictureBoxFormas.Size = new System.Drawing.Size(418, 303);
            this.pictureBoxFormas.TabIndex = 5;
            this.pictureBoxFormas.TabStop = false;
            // 
            // chkCirculo
            // 
            this.chkCirculo.AutoSize = true;
            this.chkCirculo.Location = new System.Drawing.Point(55, 202);
            this.chkCirculo.Name = "chkCirculo";
            this.chkCirculo.Size = new System.Drawing.Size(58, 17);
            this.chkCirculo.TabIndex = 6;
            this.chkCirculo.Text = "Circulo";
            this.chkCirculo.UseVisualStyleBackColor = true;
            this.chkCirculo.CheckedChanged += new System.EventHandler(this.chkCirculo_CheckedChanged);
            // 
            // FormCobinacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkCirculo);
            this.Controls.Add(this.pictureBoxFormas);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.chkLosango);
            this.Controls.Add(this.chkRetangulo);
            this.Name = "FormCobinacoes";
            this.Text = "O Programa Combinações";
            this.Load += new System.EventHandler(this.FormCobinacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRetangulo;
        private System.Windows.Forms.CheckBox chkLosango;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.PictureBox pictureBoxFormas;
        private System.Windows.Forms.CheckBox chkCirculo;
    }
}

