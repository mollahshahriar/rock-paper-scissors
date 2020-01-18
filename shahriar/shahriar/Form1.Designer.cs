namespace shahriar
{
    partial class comr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comr));
            this.Rock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.computerR = new System.Windows.Forms.PictureBox();
            this.computerP = new System.Windows.Forms.PictureBox();
            this.computerS = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.computerR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerS)).BeginInit();
            this.SuspendLayout();
            // 
            // Rock
            // 
            this.Rock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rock.BackgroundImage")));
            this.Rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rock.Location = new System.Drawing.Point(153, 94);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(75, 54);
            this.Rock.TabIndex = 0;
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(153, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(153, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(373, 250);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 3;
            // 
            // computerR
            // 
            this.computerR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("computerR.BackgroundImage")));
            this.computerR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.computerR.Location = new System.Drawing.Point(668, 85);
            this.computerR.Name = "computerR";
            this.computerR.Size = new System.Drawing.Size(81, 63);
            this.computerR.TabIndex = 4;
            this.computerR.TabStop = false;
            // 
            // computerP
            // 
            this.computerP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("computerP.BackgroundImage")));
            this.computerP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.computerP.Location = new System.Drawing.Point(668, 159);
            this.computerP.Name = "computerP";
            this.computerP.Size = new System.Drawing.Size(81, 50);
            this.computerP.TabIndex = 5;
            this.computerP.TabStop = false;
            // 
            // computerS
            // 
            this.computerS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("computerS.BackgroundImage")));
            this.computerS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.computerS.Location = new System.Drawing.Point(668, 220);
            this.computerS.Name = "computerS";
            this.computerS.Size = new System.Drawing.Size(81, 50);
            this.computerS.TabIndex = 6;
            this.computerS.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(668, 370);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // comr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.computerS);
            this.Controls.Add(this.computerP);
            this.Controls.Add(this.computerR);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Rock);
            this.Name = "comr";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.computerR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.PictureBox computerR;
        private System.Windows.Forms.PictureBox computerP;
        private System.Windows.Forms.PictureBox computerS;
        private System.Windows.Forms.Button button5;
    }
}

