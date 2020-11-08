namespace oopRobotar
{
    partial class frmMain
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
            this.lblAktuell = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblAntal = new System.Windows.Forms.Label();
            this.lblAntalS = new System.Windows.Forms.Label();
            this.numS = new System.Windows.Forms.NumericUpDown();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.lblAntalB = new System.Windows.Forms.Label();
            this.numKA = new System.Windows.Forms.NumericUpDown();
            this.lblKlarAntal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAktuell
            // 
            this.lblAktuell.AutoSize = true;
            this.lblAktuell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAktuell.Location = new System.Drawing.Point(52, 369);
            this.lblAktuell.Name = "lblAktuell";
            this.lblAktuell.Size = new System.Drawing.Size(124, 24);
            this.lblAktuell.TabIndex = 0;
            this.lblAktuell.Text = "Aktuell robot: ";
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(554, 59);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(144, 52);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Kör, baby!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblAntal
            // 
            this.lblAntal.AutoSize = true;
            this.lblAntal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntal.Location = new System.Drawing.Point(52, 295);
            this.lblAntal.Name = "lblAntal";
            this.lblAntal.Size = new System.Drawing.Size(126, 24);
            this.lblAntal.TabIndex = 2;
            this.lblAntal.Text = "Antal robotar: ";
            // 
            // lblAntalS
            // 
            this.lblAntalS.AutoSize = true;
            this.lblAntalS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntalS.Location = new System.Drawing.Point(52, 152);
            this.lblAntalS.Name = "lblAntalS";
            this.lblAntalS.Size = new System.Drawing.Size(281, 24);
            this.lblAntalS.TabIndex = 3;
            this.lblAntalS.Text = "Hur många månader samlar de?";
            // 
            // numS
            // 
            this.numS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numS.Location = new System.Drawing.Point(352, 152);
            this.numS.Name = "numS";
            this.numS.Size = new System.Drawing.Size(39, 29);
            this.numS.TabIndex = 4;
            this.numS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numS.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numB
            // 
            this.numB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numB.Location = new System.Drawing.Point(352, 99);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(39, 29);
            this.numB.TabIndex = 6;
            this.numB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numB.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblAntalB
            // 
            this.lblAntalB.AutoSize = true;
            this.lblAntalB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntalB.Location = new System.Drawing.Point(52, 99);
            this.lblAntalB.Name = "lblAntalB";
            this.lblAntalB.Size = new System.Drawing.Size(285, 24);
            this.lblAntalB.TabIndex = 5;
            this.lblAntalB.Text = "Hur många månader bygger de?";
            // 
            // numKA
            // 
            this.numKA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKA.Location = new System.Drawing.Point(315, 33);
            this.numKA.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numKA.Name = "numKA";
            this.numKA.Size = new System.Drawing.Size(76, 29);
            this.numKA.TabIndex = 8;
            this.numKA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numKA.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lblKlarAntal
            // 
            this.lblKlarAntal.AutoSize = true;
            this.lblKlarAntal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlarAntal.Location = new System.Drawing.Point(48, 33);
            this.lblKlarAntal.Name = "lblKlarAntal";
            this.lblKlarAntal.Size = new System.Drawing.Size(245, 24);
            this.lblKlarAntal.TabIndex = 7;
            this.lblKlarAntal.Text = "Hur många robotar behövs?";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numKA);
            this.Controls.Add(this.lblKlarAntal);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.lblAntalB);
            this.Controls.Add(this.numS);
            this.Controls.Add(this.lblAntalS);
            this.Controls.Add(this.lblAntal);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblAktuell);
            this.Name = "frmMain";
            this.Text = "Robotar, baby!";
            ((System.ComponentModel.ISupportInitialize)(this.numS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAktuell;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblAntal;
        private System.Windows.Forms.Label lblAntalS;
        private System.Windows.Forms.NumericUpDown numS;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.Label lblAntalB;
        private System.Windows.Forms.NumericUpDown numKA;
        private System.Windows.Forms.Label lblKlarAntal;
    }
}

