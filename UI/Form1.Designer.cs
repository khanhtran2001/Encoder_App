
namespace UI
{
    partial class homePage
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
            this.homePageLabel = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.codeBlock = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homePageLabel
            // 
            this.homePageLabel.AutoSize = true;
            this.homePageLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.homePageLabel.Location = new System.Drawing.Point(301, 43);
            this.homePageLabel.Name = "homePageLabel";
            this.homePageLabel.Size = new System.Drawing.Size(172, 41);
            this.homePageLabel.TabIndex = 0;
            this.homePageLabel.Text = "Home Page";
            this.homePageLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uploadButton.ForeColor = System.Drawing.Color.Blue;
            this.uploadButton.Location = new System.Drawing.Point(131, 227);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(121, 42);
            this.uploadButton.TabIndex = 1;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = false;
            this.uploadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // codeBlock
            // 
            this.codeBlock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBlock.Location = new System.Drawing.Point(428, 127);
            this.codeBlock.Multiline = true;
            this.codeBlock.Name = "codeBlock";
            this.codeBlock.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.codeBlock.Size = new System.Drawing.Size(363, 248);
            this.codeBlock.TabIndex = 2;
            this.codeBlock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.convertButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(340, 424);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(89, 39);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 505);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.codeBlock);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.homePageLabel);
            this.Name = "homePage";
            this.Text = "Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label homePageLabel;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.TextBox codeBlock;
        private System.Windows.Forms.Button convertButton;
    }
}

