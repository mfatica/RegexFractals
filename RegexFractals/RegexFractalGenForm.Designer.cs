namespace RegexFractals
{
    partial class RegexFractalGenForm
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
            this.ImageDisplayBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FractalRegex = new System.Windows.Forms.TextBox();
            this.FractalColor = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.FractalSize = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDisplayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalColor)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageDisplayBox
            // 
            this.ImageDisplayBox.Location = new System.Drawing.Point(12, 12);
            this.ImageDisplayBox.Name = "ImageDisplayBox";
            this.ImageDisplayBox.Size = new System.Drawing.Size(512, 512);
            this.ImageDisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageDisplayBox.TabIndex = 0;
            this.ImageDisplayBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regular Expression:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color:";
            // 
            // FractalRegex
            // 
            this.FractalRegex.Location = new System.Drawing.Point(119, 530);
            this.FractalRegex.Name = "FractalRegex";
            this.FractalRegex.Size = new System.Drawing.Size(207, 20);
            this.FractalRegex.TabIndex = 3;
            // 
            // FractalColor
            // 
            this.FractalColor.BackColor = System.Drawing.Color.Black;
            this.FractalColor.Location = new System.Drawing.Point(481, 533);
            this.FractalColor.Name = "FractalColor";
            this.FractalColor.Size = new System.Drawing.Size(43, 16);
            this.FractalColor.TabIndex = 4;
            this.FractalColor.TabStop = false;
            this.FractalColor.Click += new System.EventHandler(this.FractalColor_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(423, 555);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(101, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Size:";
            // 
            // FractalSize
            // 
            this.FractalSize.Location = new System.Drawing.Point(369, 529);
            this.FractalSize.Name = "FractalSize";
            this.FractalSize.Size = new System.Drawing.Size(65, 20);
            this.FractalSize.TabIndex = 7;
            // 
            // RegexFractalGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 584);
            this.Controls.Add(this.FractalSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.FractalColor);
            this.Controls.Add(this.FractalRegex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageDisplayBox);
            this.Name = "RegexFractalGenForm";
            this.Text = "Regular Expression Fractal Generator";
            ((System.ComponentModel.ISupportInitialize)(this.ImageDisplayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FractalColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageDisplayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FractalRegex;
        private System.Windows.Forms.PictureBox FractalColor;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FractalSize;
    }
}

