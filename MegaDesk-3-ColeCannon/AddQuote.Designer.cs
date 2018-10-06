﻿namespace MegaDesk_3_ColeCannon
{
    partial class AddQuote
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
            this.AddNewQuoteAcceptBtn = new System.Windows.Forms.Button();
            this.CancelQuoteBtn = new System.Windows.Forms.Button();
            this.HeightTitle = new System.Windows.Forms.Label();
            this.WidthTitle = new System.Windows.Forms.Label();
            this.HeightInputErrorLabel = new System.Windows.Forms.Label();
            this.WidthInputErrorLabel = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddNewQuoteAcceptBtn
            // 
            this.AddNewQuoteAcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewQuoteAcceptBtn.Location = new System.Drawing.Point(437, 326);
            this.AddNewQuoteAcceptBtn.Name = "AddNewQuoteAcceptBtn";
            this.AddNewQuoteAcceptBtn.Size = new System.Drawing.Size(195, 65);
            this.AddNewQuoteAcceptBtn.TabIndex = 1;
            this.AddNewQuoteAcceptBtn.Text = "&Add New Quote";
            this.AddNewQuoteAcceptBtn.UseVisualStyleBackColor = true;
            this.AddNewQuoteAcceptBtn.Click += new System.EventHandler(this.AddNewQuoteAccept_Click);
            // 
            // CancelQuoteBtn
            // 
            this.CancelQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelQuoteBtn.Location = new System.Drawing.Point(192, 333);
            this.CancelQuoteBtn.Name = "CancelQuoteBtn";
            this.CancelQuoteBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CancelQuoteBtn.Size = new System.Drawing.Size(195, 50);
            this.CancelQuoteBtn.TabIndex = 2;
            this.CancelQuoteBtn.Text = "&Cancel";
            this.CancelQuoteBtn.UseVisualStyleBackColor = true;
            this.CancelQuoteBtn.Click += new System.EventHandler(this.CancelQuote_Click);
            // 
            // HeightTitle
            // 
            this.HeightTitle.AutoSize = true;
            this.HeightTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTitle.Location = new System.Drawing.Point(197, 57);
            this.HeightTitle.Name = "HeightTitle";
            this.HeightTitle.Size = new System.Drawing.Size(56, 20);
            this.HeightTitle.TabIndex = 5;
            this.HeightTitle.Text = "Height";
            // 
            // WidthTitle
            // 
            this.WidthTitle.AutoSize = true;
            this.WidthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthTitle.Location = new System.Drawing.Point(442, 57);
            this.WidthTitle.Name = "WidthTitle";
            this.WidthTitle.Size = new System.Drawing.Size(50, 20);
            this.WidthTitle.TabIndex = 6;
            this.WidthTitle.Text = "Width";
            // 
            // HeightInputErrorLabel
            // 
            this.HeightInputErrorLabel.AutoSize = true;
            this.HeightInputErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.HeightInputErrorLabel.Location = new System.Drawing.Point(198, 133);
            this.HeightInputErrorLabel.Name = "HeightInputErrorLabel";
            this.HeightInputErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.HeightInputErrorLabel.TabIndex = 7;
            this.HeightInputErrorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WidthInputErrorLabel
            // 
            this.WidthInputErrorLabel.AutoSize = true;
            this.WidthInputErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WidthInputErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.WidthInputErrorLabel.Location = new System.Drawing.Point(443, 133);
            this.WidthInputErrorLabel.Name = "WidthInputErrorLabel";
            this.WidthInputErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.WidthInputErrorLabel.TabIndex = 8;
            // 
            // HeightInput
            // 
            this.HeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInput.Location = new System.Drawing.Point(201, 80);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(100, 38);
            this.HeightInput.TabIndex = 9;
            this.HeightInput.Validating += new System.ComponentModel.CancelEventHandler(this.HeightInputValidation);
            // 
            // WidthInput
            // 
            this.WidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthInput.Location = new System.Drawing.Point(446, 80);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(100, 38);
            this.WidthInput.TabIndex = 10;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.WidthInputErrorLabel);
            this.Controls.Add(this.HeightInputErrorLabel);
            this.Controls.Add(this.WidthTitle);
            this.Controls.Add(this.HeightTitle);
            this.Controls.Add(this.CancelQuoteBtn);
            this.Controls.Add(this.AddNewQuoteAcceptBtn);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuoteAcceptBtn;
        private System.Windows.Forms.Button CancelQuoteBtn;
        private System.Windows.Forms.Label HeightTitle;
        private System.Windows.Forms.Label WidthTitle;
        private System.Windows.Forms.Label HeightInputErrorLabel;
        private System.Windows.Forms.Label WidthInputErrorLabel;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.TextBox WidthInput;
    }
}