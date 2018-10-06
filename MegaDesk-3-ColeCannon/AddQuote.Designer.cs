namespace MegaDesk_3_ColeCannon
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
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelQuoteBtn);
            this.Controls.Add(this.AddNewQuoteAcceptBtn);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuoteAcceptBtn;
        private System.Windows.Forms.Button CancelQuoteBtn;
    }
}