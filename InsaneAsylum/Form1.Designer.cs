namespace InsaneAsylum
{
    partial class Form1
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
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.sceneTester = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel1
            // 
            this.outputLabel1.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel1.Font = new System.Drawing.Font("Rockwell Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.outputLabel1.Location = new System.Drawing.Point(201, 18);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(961, 140);
            this.outputLabel1.TabIndex = 0;
            this.outputLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sceneTester
            // 
            this.sceneTester.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sceneTester.ForeColor = System.Drawing.Color.LimeGreen;
            this.sceneTester.Location = new System.Drawing.Point(1168, 18);
            this.sceneTester.Name = "sceneTester";
            this.sceneTester.Size = new System.Drawing.Size(100, 23);
            this.sceneTester.TabIndex = 1;
            this.sceneTester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(859, 681);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press C for 1st choice, B for middle (if 3 choices), and M for last.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sceneTester);
            this.Controls.Add(this.outputLabel1);
            this.Name = "Form1";
            this.Text = "Can You Escape?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Label sceneTester;
        private System.Windows.Forms.Label label1;
    }
}

