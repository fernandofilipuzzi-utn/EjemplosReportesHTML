﻿
namespace Ej1_PDFdesdeHTML_Desktop
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.lnklbficheroPDF = new System.Windows.Forms.LinkLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lnklbficheroHTML = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.vwPDF = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbURL = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Location = new System.Drawing.Point(547, 6);
            this.btnGenerarPDF.Margin = new System.Windows.Forms.Padding(6);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(228, 58);
            this.btnGenerarPDF.TabIndex = 27;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // lnklbficheroPDF
            // 
            this.lnklbficheroPDF.AutoSize = true;
            this.lnklbficheroPDF.Location = new System.Drawing.Point(222, 133);
            this.lnklbficheroPDF.Name = "lnklbficheroPDF";
            this.lnklbficheroPDF.Size = new System.Drawing.Size(0, 20);
            this.lnklbficheroPDF.TabIndex = 28;
            this.lnklbficheroPDF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbficheroPDF_LinkClicked);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "selectetPDF",
            "itext7.pdfhtmlClassLib"});
            this.comboBox2.Location = new System.Drawing.Point(221, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(268, 28);
            this.comboBox2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Seleccionar librería";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lnklbficheroHTML
            // 
            this.lnklbficheroHTML.AutoSize = true;
            this.lnklbficheroHTML.Location = new System.Drawing.Point(222, 105);
            this.lnklbficheroHTML.Name = "lnklbficheroHTML";
            this.lnklbficheroHTML.Size = new System.Drawing.Size(0, 20);
            this.lnklbficheroHTML.TabIndex = 33;
            this.lnklbficheroHTML.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbficheroHTML_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 26);
            this.button1.TabIndex = 34;
            this.button1.Text = "Seleccionar HTML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Fichero de entrada (HTML):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Fichero de salida(PDF):";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.vwPDF);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 170);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(836, 516);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // vwPDF
            // 
            this.vwPDF.AllowExternalDrop = true;
            this.vwPDF.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.vwPDF.CreationProperties = null;
            this.vwPDF.DefaultBackgroundColor = System.Drawing.Color.White;
            this.vwPDF.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vwPDF.Location = new System.Drawing.Point(3, 3);
            this.vwPDF.Name = "vwPDF";
            this.vwPDF.Size = new System.Drawing.Size(832, 510);
            this.vwPDF.TabIndex = 32;
            this.vwPDF.ZoomFactor = 1D;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 26);
            this.textBox1.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "URL:";
            // 
            // rbURL
            // 
            this.rbURL.AutoSize = true;
            this.rbURL.Location = new System.Drawing.Point(495, 71);
            this.rbURL.Name = "rbURL";
            this.rbURL.Size = new System.Drawing.Size(60, 24);
            this.rbURL.TabIndex = 40;
            this.rbURL.TabStop = true;
            this.rbURL.Text = "URL";
            this.rbURL.UseVisualStyleBackColor = true;
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Location = new System.Drawing.Point(495, 102);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(65, 24);
            this.rbLocal.TabIndex = 41;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 686);
            this.Controls.Add(this.rbLocal);
            this.Controls.Add(this.rbURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lnklbficheroHTML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lnklbficheroPDF);
            this.Controls.Add(this.btnGenerarPDF);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vwPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.LinkLabel lnklbficheroPDF;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel lnklbficheroHTML;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 vwPDF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbURL;
        private System.Windows.Forms.RadioButton rbLocal;
    }
}

