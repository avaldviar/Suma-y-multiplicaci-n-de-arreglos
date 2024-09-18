namespace ReservacionAerolinea
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBoardingPass = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rdoNonSmoking = new System.Windows.Forms.RadioButton();
            this.rdoSmoking = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(294, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblBoardingPass
            // 
            this.lblBoardingPass.AutoSize = true;
            this.lblBoardingPass.Location = new System.Drawing.Point(155, 211);
            this.lblBoardingPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBoardingPass.Name = "lblBoardingPass";
            this.lblBoardingPass.Size = new System.Drawing.Size(0, 13);
            this.lblBoardingPass.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSubmit.Location = new System.Drawing.Point(403, 247);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 34);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Asignar Asiento";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // rdoNonSmoking
            // 
            this.rdoNonSmoking.AutoSize = true;
            this.rdoNonSmoking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNonSmoking.Location = new System.Drawing.Point(114, 188);
            this.rdoNonSmoking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoNonSmoking.Name = "rdoNonSmoking";
            this.rdoNonSmoking.Size = new System.Drawing.Size(88, 21);
            this.rdoNonSmoking.TabIndex = 9;
            this.rdoNonSmoking.TabStop = true;
            this.rdoNonSmoking.Text = "No Fumar";
            this.rdoNonSmoking.UseVisualStyleBackColor = true;
            // 
            // rdoSmoking
            // 
            this.rdoSmoking.AutoSize = true;
            this.rdoSmoking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSmoking.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoSmoking.Location = new System.Drawing.Point(376, 188);
            this.rdoSmoking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoSmoking.Name = "rdoSmoking";
            this.rdoSmoking.Size = new System.Drawing.Size(71, 21);
            this.rdoSmoking.TabIndex = 8;
            this.rdoSmoking.TabStop = true;
            this.rdoSmoking.Text = "Fumar";
            this.rdoSmoking.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(127, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecciona su preferencia de asiento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(95, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sistema de reservaciones de aerolínea";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(36, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Agrega un pasajero";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(228, 90);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(154, 31);
            this.tbNombre.TabIndex = 16;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nombre del pasajero:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBoardingPass);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdoNonSmoking);
            this.Controls.Add(this.rdoSmoking);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBoardingPass;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdoNonSmoking;
        private System.Windows.Forms.RadioButton rdoSmoking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
    }
}

