namespace TempConverterApp
{
    partial class MainForm
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
            this.lblFarhenheit = new System.Windows.Forms.Label();
            this.txtFarhenheit = new System.Windows.Forms.TextBox();
            this.btnConvertTemp = new System.Windows.Forms.Button();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFarhenheit
            // 
            this.lblFarhenheit.AutoSize = true;
            this.lblFarhenheit.Location = new System.Drawing.Point(66, 47);
            this.lblFarhenheit.Name = "lblFarhenheit";
            this.lblFarhenheit.Size = new System.Drawing.Size(70, 16);
            this.lblFarhenheit.TabIndex = 0;
            this.lblFarhenheit.Text = "Farhenheit";
            // 
            // txtFarhenheit
            // 
            this.txtFarhenheit.Location = new System.Drawing.Point(170, 41);
            this.txtFarhenheit.Name = "txtFarhenheit";
            this.txtFarhenheit.Size = new System.Drawing.Size(141, 22);
            this.txtFarhenheit.TabIndex = 1;
            // 
            // btnConvertTemp
            // 
            this.btnConvertTemp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConvertTemp.Location = new System.Drawing.Point(69, 110);
            this.btnConvertTemp.Name = "btnConvertTemp";
            this.btnConvertTemp.Size = new System.Drawing.Size(135, 47);
            this.btnConvertTemp.TabIndex = 2;
            this.btnConvertTemp.Text = "ConvertTemp";
            this.btnConvertTemp.UseVisualStyleBackColor = false;
            this.btnConvertTemp.Click += new System.EventHandler(this.btnConvertTemp_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Enabled = false;
            this.txtCelsius.Location = new System.Drawing.Point(180, 205);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(141, 22);
            this.txtCelsius.TabIndex = 4;
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(76, 211);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(51, 16);
            this.lblCelsius.TabIndex = 3;
            this.lblCelsius.Text = "Celsius";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 303);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.btnConvertTemp);
            this.Controls.Add(this.txtFarhenheit);
            this.Controls.Add(this.lblFarhenheit);
            this.Name = "MainForm";
            this.Text = "Temp Converter Service Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFarhenheit;
        private System.Windows.Forms.TextBox txtFarhenheit;
        private System.Windows.Forms.Button btnConvertTemp;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Label lblCelsius;
    }
}

