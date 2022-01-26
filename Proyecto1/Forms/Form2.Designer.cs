namespace Cliente
{
    partial class Form2
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
            this.aceptarbtn = new System.Windows.Forms.Button();
            this.rechazarbtn = new System.Windows.Forms.Button();
            this.lblinvitacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aceptarbtn
            // 
            this.aceptarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarbtn.Location = new System.Drawing.Point(68, 181);
            this.aceptarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.aceptarbtn.Name = "aceptarbtn";
            this.aceptarbtn.Size = new System.Drawing.Size(137, 71);
            this.aceptarbtn.TabIndex = 0;
            this.aceptarbtn.Text = "Aceptar";
            this.aceptarbtn.UseVisualStyleBackColor = true;
            this.aceptarbtn.Click += new System.EventHandler(this.aceptarbtn_Click);
            // 
            // rechazarbtn
            // 
            this.rechazarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rechazarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechazarbtn.Location = new System.Drawing.Point(249, 181);
            this.rechazarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.rechazarbtn.Name = "rechazarbtn";
            this.rechazarbtn.Size = new System.Drawing.Size(139, 71);
            this.rechazarbtn.TabIndex = 1;
            this.rechazarbtn.Text = "Rechazar";
            this.rechazarbtn.UseVisualStyleBackColor = true;
            this.rechazarbtn.Click += new System.EventHandler(this.rechazarbtn_Click);
            // 
            // lblinvitacion
            // 
            this.lblinvitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvitacion.Location = new System.Drawing.Point(41, 89);
            this.lblinvitacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinvitacion.Name = "lblinvitacion";
            this.lblinvitacion.Size = new System.Drawing.Size(392, 51);
            this.lblinvitacion.TabIndex = 2;
            this.lblinvitacion.Text = "label1";
            this.lblinvitacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 302);
            this.Controls.Add(this.lblinvitacion);
            this.Controls.Add(this.rechazarbtn);
            this.Controls.Add(this.aceptarbtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aceptarbtn;
        private System.Windows.Forms.Button rechazarbtn;
        private System.Windows.Forms.Label lblinvitacion;
    }
}