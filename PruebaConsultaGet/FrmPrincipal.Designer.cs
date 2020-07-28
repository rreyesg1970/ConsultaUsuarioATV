namespace PruebaConsultaGet
{
    partial class FrmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direccion URL";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(15, 34);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(507, 20);
            this.TxtUrl.TabIndex = 1;
            this.TxtUrl.Text = "https://api.hacienda.go.cr/fe/agropecuario?identificacion=";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(355, 99);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(164, 23);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtResultado.Location = new System.Drawing.Point(12, 178);
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtResultado.Size = new System.Drawing.Size(507, 293);
            this.TxtResultado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Respuesta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cédula física, jurídica, residencia (Dimex) o Pasaporte (NITE)";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(12, 102);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(190, 20);
            this.TxtCedula.TabIndex = 7;
            this.TxtCedula.Text = "109690498";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 483);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de número de Identificación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCedula;
    }
}

