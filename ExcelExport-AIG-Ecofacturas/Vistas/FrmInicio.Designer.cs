namespace ExcelExport_AIG_Ecofacturas
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFormatoSalida = new System.Windows.Forms.Button();
            this.btnFormatoEntrada = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(861, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exportar excel AIG - Ecofacturas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnFormatoSalida
            // 
            this.BtnFormatoSalida.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnFormatoSalida.Enabled = false;
            this.BtnFormatoSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFormatoSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFormatoSalida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFormatoSalida.Image = global::ExcelExport_AIG_Ecofacturas.Properties.Resources.icons8_microsoft_excel_48;
            this.BtnFormatoSalida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFormatoSalida.Location = new System.Drawing.Point(54, 313);
            this.BtnFormatoSalida.Name = "BtnFormatoSalida";
            this.BtnFormatoSalida.Size = new System.Drawing.Size(282, 84);
            this.BtnFormatoSalida.TabIndex = 7;
            this.BtnFormatoSalida.Text = "Formato Salida";
            this.BtnFormatoSalida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFormatoSalida.UseVisualStyleBackColor = false;
            // 
            // btnFormatoEntrada
            // 
            this.btnFormatoEntrada.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFormatoEntrada.Enabled = false;
            this.btnFormatoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormatoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormatoEntrada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFormatoEntrada.Image = global::ExcelExport_AIG_Ecofacturas.Properties.Resources.icons8_microsoft_excel_48;
            this.btnFormatoEntrada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFormatoEntrada.Location = new System.Drawing.Point(54, 212);
            this.btnFormatoEntrada.Name = "btnFormatoEntrada";
            this.btnFormatoEntrada.Size = new System.Drawing.Size(282, 84);
            this.btnFormatoEntrada.TabIndex = 6;
            this.btnFormatoEntrada.Text = "Formato Entrada";
            this.btnFormatoEntrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFormatoEntrada.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Image = global::ExcelExport_AIG_Ecofacturas.Properties.Resources.icons8_external_48;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportar.Location = new System.Drawing.Point(54, 112);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(282, 84);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(861, 512);
            this.Controls.Add(this.BtnFormatoSalida);
            this.Controls.Add(this.btnFormatoEntrada);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnFormatoEntrada;
        private System.Windows.Forms.Button BtnFormatoSalida;
    }
}