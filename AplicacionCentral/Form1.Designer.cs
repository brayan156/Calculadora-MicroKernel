﻿
namespace AplicacionCentral
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
            this.label1 = new System.Windows.Forms.Label();
            this.Op1Box = new System.Windows.Forms.TextBox();
            this.Op2Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.PluginsCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BRealizar = new System.Windows.Forms.Button();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operando1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Op1Box
            // 
            this.Op1Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Op1Box.Location = new System.Drawing.Point(100, 23);
            this.Op1Box.Name = "Op1Box";
            this.Op1Box.Size = new System.Drawing.Size(100, 29);
            this.Op1Box.TabIndex = 1;
            this.Op1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Op2Box
            // 
            this.Op2Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Op2Box.Location = new System.Drawing.Point(320, 23);
            this.Op2Box.Name = "Op2Box";
            this.Op2Box.Size = new System.Drawing.Size(100, 29);
            this.Op2Box.TabIndex = 3;
            this.Op2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(222, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operando2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelResult.Location = new System.Drawing.Point(90, 75);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(0, 21);
            this.LabelResult.TabIndex = 5;
            this.LabelResult.Click += new System.EventHandler(this.label4_Click);
            // 
            // PluginsCombo
            // 
            this.PluginsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PluginsCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PluginsCombo.FormattingEnabled = true;
            this.PluginsCombo.Location = new System.Drawing.Point(193, 115);
            this.PluginsCombo.Name = "PluginsCombo";
            this.PluginsCombo.Size = new System.Drawing.Size(121, 29);
            this.PluginsCombo.TabIndex = 6;
            this.PluginsCombo.SelectedIndexChanged += new System.EventHandler(this.PluginsCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(2, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Elija el tipo de operacion:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(2, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descripcion:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(100, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 21);
            this.label7.TabIndex = 9;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BRealizar
            // 
            this.BRealizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BRealizar.Location = new System.Drawing.Point(334, 115);
            this.BRealizar.Name = "BRealizar";
            this.BRealizar.Size = new System.Drawing.Size(98, 29);
            this.BRealizar.TabIndex = 10;
            this.BRealizar.Text = "Realizar";
            this.BRealizar.UseVisualStyleBackColor = true;
            this.BRealizar.Click += new System.EventHandler(this.BRealizar_Click);
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDescripcion.Location = new System.Drawing.Point(102, 182);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(0, 21);
            this.LabelDescripcion.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.LabelDescripcion);
            this.Controls.Add(this.BRealizar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PluginsCombo);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Op2Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Op1Box);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Op1Box;
        private System.Windows.Forms.TextBox Op2Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.ComboBox PluginsCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BRealizar;
        private System.Windows.Forms.Label LabelDescripcion;
    }
}

