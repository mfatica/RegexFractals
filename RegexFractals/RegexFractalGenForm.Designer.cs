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
               this.GenerateFractal = new System.Windows.Forms.Button();
               this.ColorPicker = new System.Windows.Forms.ColorDialog();
               this.label3 = new System.Windows.Forms.Label();
               this.FractalSize = new System.Windows.Forms.TextBox();
               this.SaveImage = new System.Windows.Forms.Button();
               this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
               this.StretchImage = new System.Windows.Forms.CheckBox();
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
               // GenerateFractal
               // 
               this.GenerateFractal.Location = new System.Drawing.Point(374, 555);
               this.GenerateFractal.Name = "GenerateFractal";
               this.GenerateFractal.Size = new System.Drawing.Size(101, 23);
               this.GenerateFractal.TabIndex = 5;
               this.GenerateFractal.Text = "Generate";
               this.GenerateFractal.UseVisualStyleBackColor = true;
               this.GenerateFractal.Click += new System.EventHandler(this.btnGenerate_Click);
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
               // SaveImage
               // 
               this.SaveImage.Location = new System.Drawing.Point(481, 555);
               this.SaveImage.Name = "SaveImage";
               this.SaveImage.Size = new System.Drawing.Size(43, 23);
               this.SaveImage.TabIndex = 8;
               this.SaveImage.Text = "Save";
               this.SaveImage.UseVisualStyleBackColor = true;
               this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
               // 
               // StretchImage
               // 
               this.StretchImage.AutoSize = true;
               this.StretchImage.Checked = true;
               this.StretchImage.CheckState = System.Windows.Forms.CheckState.Checked;
               this.StretchImage.Location = new System.Drawing.Point(276, 559);
               this.StretchImage.Name = "StretchImage";
               this.StretchImage.Size = new System.Drawing.Size(92, 17);
               this.StretchImage.TabIndex = 9;
               this.StretchImage.Text = "Stretch Image";
               this.StretchImage.UseVisualStyleBackColor = true;
               this.StretchImage.CheckedChanged += new System.EventHandler(this.StretchImage_CheckedChanged);
               // 
               // RegexFractalGenForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(535, 584);
               this.Controls.Add(this.StretchImage);
               this.Controls.Add(this.SaveImage);
               this.Controls.Add(this.FractalSize);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.GenerateFractal);
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
        private System.Windows.Forms.Button GenerateFractal;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FractalSize;
        private System.Windows.Forms.Button SaveImage;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.CheckBox StretchImage;
    }
}

