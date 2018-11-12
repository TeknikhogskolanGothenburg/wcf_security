namespace WindowsClient
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
            this.btnGetMessage = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNoProtection = new System.Windows.Forms.Button();
            this.btnGetMessageSigned = new System.Windows.Forms.Button();
            this.btnGetMessageSignedAndEncrypted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetMessage
            // 
            this.btnGetMessage.Location = new System.Drawing.Point(260, 138);
            this.btnGetMessage.Name = "btnGetMessage";
            this.btnGetMessage.Size = new System.Drawing.Size(208, 57);
            this.btnGetMessage.TabIndex = 0;
            this.btnGetMessage.Text = "Get Message";
            this.btnGetMessage.UseVisualStyleBackColor = true;
            this.btnGetMessage.Click += new System.EventHandler(this.btnGetMessage_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(260, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 26);
            this.txtName.TabIndex = 1;
            // 
            // btnNoProtection
            // 
            this.btnNoProtection.Location = new System.Drawing.Point(243, 219);
            this.btnNoProtection.Name = "btnNoProtection";
            this.btnNoProtection.Size = new System.Drawing.Size(256, 36);
            this.btnNoProtection.TabIndex = 2;
            this.btnNoProtection.Text = "Get Message No Protection";
            this.btnNoProtection.UseVisualStyleBackColor = true;
            this.btnNoProtection.Click += new System.EventHandler(this.btnNoProtection_Click);
            // 
            // btnGetMessageSigned
            // 
            this.btnGetMessageSigned.Location = new System.Drawing.Point(243, 272);
            this.btnGetMessageSigned.Name = "btnGetMessageSigned";
            this.btnGetMessageSigned.Size = new System.Drawing.Size(254, 33);
            this.btnGetMessageSigned.TabIndex = 3;
            this.btnGetMessageSigned.Text = "Get Sigend Message";
            this.btnGetMessageSigned.UseVisualStyleBackColor = true;
            this.btnGetMessageSigned.Click += new System.EventHandler(this.btnGetMessageSigned_Click);
            // 
            // btnGetMessageSignedAndEncrypted
            // 
            this.btnGetMessageSignedAndEncrypted.Location = new System.Drawing.Point(230, 331);
            this.btnGetMessageSignedAndEncrypted.Name = "btnGetMessageSignedAndEncrypted";
            this.btnGetMessageSignedAndEncrypted.Size = new System.Drawing.Size(300, 46);
            this.btnGetMessageSignedAndEncrypted.TabIndex = 4;
            this.btnGetMessageSignedAndEncrypted.Text = "Get Sigend and Encrytped Message";
            this.btnGetMessageSignedAndEncrypted.UseVisualStyleBackColor = true;
            this.btnGetMessageSignedAndEncrypted.Click += new System.EventHandler(this.btnGetMessageSignedAndEncrypted_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetMessageSignedAndEncrypted);
            this.Controls.Add(this.btnGetMessageSigned);
            this.Controls.Add(this.btnNoProtection);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnGetMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnNoProtection;
        private System.Windows.Forms.Button btnGetMessageSigned;
        private System.Windows.Forms.Button btnGetMessageSignedAndEncrypted;
    }
}

