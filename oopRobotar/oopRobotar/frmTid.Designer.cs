namespace oopRobotar
{
    partial class frmTid
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
            this.components = new System.ComponentModel.Container();
            this.lblTid = new System.Windows.Forms.Label();
            this.tmrManad = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTid.Location = new System.Drawing.Point(13, 9);
            this.lblTid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(304, 24);
            this.lblTid.TabIndex = 0;
            this.lblTid.Text = "Vi börjar med en robot som samlar.";
            // 
            // tmrManad
            // 
            this.tmrManad.Interval = 400;
            this.tmrManad.Tick += new System.EventHandler(this.tmrManad_Tick);
            // 
            // frmTid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblTid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTid";
            this.Text = "Tiden går, baby!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTid;
        private System.Windows.Forms.Timer tmrManad;
    }
}