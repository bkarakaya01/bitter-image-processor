
namespace Bitter.ImageProcessor
{
    partial class ProcessorWindow
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
            this.selectedImagePB = new System.Windows.Forms.PictureBox();
            this.processedImgPB = new System.Windows.Forms.PictureBox();
            this.chooseImgBtn = new System.Windows.Forms.Button();
            this.saveImgBtn = new System.Windows.Forms.Button();
            this.redColorTB = new System.Windows.Forms.TrackBar();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.greenColorTB = new System.Windows.Forms.TrackBar();
            this.lblBlue = new System.Windows.Forms.Label();
            this.blueColorTB = new System.Windows.Forms.TrackBar();
            this.redNumericUD = new System.Windows.Forms.NumericUpDown();
            this.blueNumericUD = new System.Windows.Forms.NumericUpDown();
            this.greenNumericUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImagePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImgPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColorTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColorTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedImagePB
            // 
            this.selectedImagePB.Location = new System.Drawing.Point(200, 100);
            this.selectedImagePB.Name = "selectedImagePB";
            this.selectedImagePB.Size = new System.Drawing.Size(400, 300);
            this.selectedImagePB.TabIndex = 0;
            this.selectedImagePB.TabStop = false;
            // 
            // processedImgPB
            // 
            this.processedImgPB.Location = new System.Drawing.Point(680, 100);
            this.processedImgPB.Name = "processedImgPB";
            this.processedImgPB.Size = new System.Drawing.Size(400, 300);
            this.processedImgPB.TabIndex = 1;
            this.processedImgPB.TabStop = false;
            // 
            // chooseImgBtn
            // 
            this.chooseImgBtn.Location = new System.Drawing.Point(200, 433);
            this.chooseImgBtn.Name = "chooseImgBtn";
            this.chooseImgBtn.Size = new System.Drawing.Size(400, 29);
            this.chooseImgBtn.TabIndex = 2;
            this.chooseImgBtn.Text = "Choose Image";
            this.chooseImgBtn.UseVisualStyleBackColor = true;
            this.chooseImgBtn.Click += new System.EventHandler(this.chooseImgBtn_Click);
            // 
            // saveImgBtn
            // 
            this.saveImgBtn.Location = new System.Drawing.Point(680, 433);
            this.saveImgBtn.Name = "saveImgBtn";
            this.saveImgBtn.Size = new System.Drawing.Size(400, 29);
            this.saveImgBtn.TabIndex = 3;
            this.saveImgBtn.Text = "Save Image";
            this.saveImgBtn.UseVisualStyleBackColor = true;
            this.saveImgBtn.Click += new System.EventHandler(this.saveImgBtn_Click);
            // 
            // redColorTB
            // 
            this.redColorTB.Enabled = false;
            this.redColorTB.Location = new System.Drawing.Point(233, 508);
            this.redColorTB.Maximum = 255;
            this.redColorTB.Name = "redColorTB";
            this.redColorTB.Size = new System.Drawing.Size(790, 45);
            this.redColorTB.TabIndex = 4;
            this.redColorTB.Scroll += new System.EventHandler(this.redColorTB_Scroll);
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(200, 670);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(400, 29);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRed.Location = new System.Drawing.Point(200, 508);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 21);
            this.lblRed.TabIndex = 6;
            this.lblRed.Text = "R :";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGreen.Location = new System.Drawing.Point(200, 556);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(28, 21);
            this.lblGreen.TabIndex = 8;
            this.lblGreen.Text = "G :";
            // 
            // greenColorTB
            // 
            this.greenColorTB.Enabled = false;
            this.greenColorTB.Location = new System.Drawing.Point(233, 561);
            this.greenColorTB.Maximum = 255;
            this.greenColorTB.Name = "greenColorTB";
            this.greenColorTB.Size = new System.Drawing.Size(790, 45);
            this.greenColorTB.TabIndex = 7;
            this.greenColorTB.Scroll += new System.EventHandler(this.greenColorTB_Scroll);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBlue.Location = new System.Drawing.Point(200, 610);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(26, 21);
            this.lblBlue.TabIndex = 10;
            this.lblBlue.Text = "B :";
            // 
            // blueColorTB
            // 
            this.blueColorTB.Enabled = false;
            this.blueColorTB.Location = new System.Drawing.Point(233, 610);
            this.blueColorTB.Maximum = 255;
            this.blueColorTB.Name = "blueColorTB";
            this.blueColorTB.Size = new System.Drawing.Size(790, 45);
            this.blueColorTB.TabIndex = 9;
            this.blueColorTB.Scroll += new System.EventHandler(this.blueColorTB_Scroll);
            // 
            // redNumericUD
            // 
            this.redNumericUD.Enabled = false;
            this.redNumericUD.Location = new System.Drawing.Point(1029, 508);
            this.redNumericUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redNumericUD.Name = "redNumericUD";
            this.redNumericUD.Size = new System.Drawing.Size(51, 23);
            this.redNumericUD.TabIndex = 11;
            // 
            // blueNumericUD
            // 
            this.blueNumericUD.Enabled = false;
            this.blueNumericUD.Location = new System.Drawing.Point(1029, 610);
            this.blueNumericUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueNumericUD.Name = "blueNumericUD";
            this.blueNumericUD.Size = new System.Drawing.Size(51, 23);
            this.blueNumericUD.TabIndex = 12;
            // 
            // greenNumericUD
            // 
            this.greenNumericUD.Enabled = false;
            this.greenNumericUD.Location = new System.Drawing.Point(1029, 561);
            this.greenNumericUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenNumericUD.Name = "greenNumericUD";
            this.greenNumericUD.Size = new System.Drawing.Size(51, 23);
            this.greenNumericUD.TabIndex = 13;
            // 
            // ProcessorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.greenNumericUD);
            this.Controls.Add(this.blueNumericUD);
            this.Controls.Add(this.redNumericUD);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.blueColorTB);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.greenColorTB);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.redColorTB);
            this.Controls.Add(this.saveImgBtn);
            this.Controls.Add(this.chooseImgBtn);
            this.Controls.Add(this.processedImgPB);
            this.Controls.Add(this.selectedImagePB);
            this.Name = "ProcessorWindow";
            this.Text = "ProcessorWindow";
            ((System.ComponentModel.ISupportInitialize)(this.selectedImagePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImgPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColorTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColorTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNumericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumericUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox selectedImagePB;
        private System.Windows.Forms.PictureBox processedImgPB;
        private System.Windows.Forms.Button chooseImgBtn;
        private System.Windows.Forms.Button saveImgBtn;
        private System.Windows.Forms.TrackBar redColorTB;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.TrackBar greenColorTB;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.TrackBar blueColorTB;
        private System.Windows.Forms.NumericUpDown redNumericUD;
        private System.Windows.Forms.NumericUpDown blueNumericUD;
        private System.Windows.Forms.NumericUpDown greenNumericUD;
    }
}