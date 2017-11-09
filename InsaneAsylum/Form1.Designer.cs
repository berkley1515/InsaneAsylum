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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.sceneTester = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.right = new System.Windows.Forms.PictureBox();
            this.middle = new System.Windows.Forms.PictureBox();
            this.left = new System.Windows.Forms.PictureBox();
            this.resartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
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
            // cLabel
            // 
            this.cLabel.Font = new System.Drawing.Font("Rockwell Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cLabel.Location = new System.Drawing.Point(121, 619);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(322, 62);
            this.cLabel.TabIndex = 3;
            this.cLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bLabel
            // 
            this.bLabel.Font = new System.Drawing.Font("Rockwell Condensed", 21.75F);
            this.bLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bLabel.Location = new System.Drawing.Point(544, 619);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(322, 62);
            this.bLabel.TabIndex = 4;
            this.bLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mLabel
            // 
            this.mLabel.Font = new System.Drawing.Font("Rockwell Condensed", 21.75F);
            this.mLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mLabel.Location = new System.Drawing.Point(983, 619);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(328, 62);
            this.mLabel.TabIndex = 5;
            this.mLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // right
            // 
            this.right.BackgroundImage = global::InsaneAsylum.Properties.Resources.right;
            this.right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.right.Location = new System.Drawing.Point(874, 609);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(103, 89);
            this.right.TabIndex = 8;
            this.right.TabStop = false;
            // 
            // middle
            // 
            this.middle.BackgroundImage = global::InsaneAsylum.Properties.Resources.middle;
            this.middle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.middle.Location = new System.Drawing.Point(449, 609);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(103, 89);
            this.middle.TabIndex = 7;
            this.middle.TabStop = false;
            // 
            // left
            // 
            this.left.BackgroundImage = global::InsaneAsylum.Properties.Resources.left;
            this.left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.left.Location = new System.Drawing.Point(12, 609);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(103, 89);
            this.left.TabIndex = 6;
            this.left.TabStop = false;
            // 
            // resartLabel
            // 
            this.resartLabel.Font = new System.Drawing.Font("Rockwell Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resartLabel.ForeColor = System.Drawing.Color.White;
            this.resartLabel.Location = new System.Drawing.Point(561, 270);
            this.resartLabel.Name = "resartLabel";
            this.resartLabel.Size = new System.Drawing.Size(305, 53);
            this.resartLabel.TabIndex = 9;
            this.resartLabel.Text = "Press B to restart";
            this.resartLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.resartLabel);
            this.Controls.Add(this.right);
            this.Controls.Add(this.middle);
            this.Controls.Add(this.left);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.sceneTester);
            this.Controls.Add(this.outputLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Can You Escape?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Label sceneTester;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.PictureBox left;
        private System.Windows.Forms.PictureBox middle;
        private System.Windows.Forms.PictureBox right;
        private System.Windows.Forms.Label resartLabel;
    }
}

