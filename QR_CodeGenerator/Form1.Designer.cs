
namespace QR_CodeGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.box_Code = new System.Windows.Forms.PictureBox();
            this.btn_CodeGenerator = new System.Windows.Forms.Button();
            this.txt_Code = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.box_Code)).BeginInit();
            this.SuspendLayout();
            // 
            // box_Code
            // 
            this.box_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_Code.Location = new System.Drawing.Point(12, 12);
            this.box_Code.Name = "box_Code";
            this.box_Code.Size = new System.Drawing.Size(406, 384);
            this.box_Code.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.box_Code.TabIndex = 0;
            this.box_Code.TabStop = false;
            // 
            // btn_CodeGenerator
            // 
            this.btn_CodeGenerator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CodeGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CodeGenerator.ForeColor = System.Drawing.Color.White;
            this.btn_CodeGenerator.Location = new System.Drawing.Point(14, 440);
            this.btn_CodeGenerator.Name = "btn_CodeGenerator";
            this.btn_CodeGenerator.Size = new System.Drawing.Size(405, 92);
            this.btn_CodeGenerator.TabIndex = 1;
            this.btn_CodeGenerator.Text = "QR_Code";
            this.btn_CodeGenerator.UseVisualStyleBackColor = true;
            this.btn_CodeGenerator.Click += new System.EventHandler(this.btn_CodeGenerator_Click);
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(13, 403);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(404, 31);
            this.txt_Code.TabIndex = 2;
            this.txt_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(431, 548);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.btn_CodeGenerator);
            this.Controls.Add(this.box_Code);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR_CodeGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.box_Code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox box_Code;
        private System.Windows.Forms.Button btn_CodeGenerator;
        private System.Windows.Forms.TextBox txt_Code;
    }
}

