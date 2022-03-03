
namespace WinFormsApp1_tarea_11
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
            this.bttn_variaciones = new System.Windows.Forms.Button();
            this.txtBx_salida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_variaciones
            // 
            this.bttn_variaciones.Location = new System.Drawing.Point(12, 35);
            this.bttn_variaciones.Name = "bttn_variaciones";
            this.bttn_variaciones.Size = new System.Drawing.Size(895, 37);
            this.bttn_variaciones.TabIndex = 0;
            this.bttn_variaciones.Text = "Posibles variaciones - dias";
            this.bttn_variaciones.UseVisualStyleBackColor = true;
            this.bttn_variaciones.Click += new System.EventHandler(this.bttn_variaciones_Click);
            // 
            // txtBx_salida
            // 
            this.txtBx_salida.Location = new System.Drawing.Point(12, 78);
            this.txtBx_salida.Multiline = true;
            this.txtBx_salida.Name = "txtBx_salida";
            this.txtBx_salida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBx_salida.Size = new System.Drawing.Size(895, 298);
            this.txtBx_salida.TabIndex = 1;
            this.txtBx_salida.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarea 11 - 12 : Presionar para cambiar a dias o meses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_salida);
            this.Controls.Add(this.bttn_variaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_variaciones;
        private System.Windows.Forms.TextBox txtBx_salida;
        private System.Windows.Forms.Label label1;
    }
}

