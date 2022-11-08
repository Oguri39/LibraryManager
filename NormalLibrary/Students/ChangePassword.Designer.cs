namespace NormalLibrary.Students
{
    partial class ChangePassword
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(12, 220);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 27);
            this.btnOk.TabIndex = 38;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(182, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 27);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(12, 93);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(272, 27);
            this.txtNewPassword.TabIndex = 36;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(12, 31);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(272, 27);
            this.txtCurrentPassword.TabIndex = 35;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(8, 70);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(129, 20);
            this.lbLastName.TabIndex = 34;
            this.lbLastName.Text = "New password:";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(8, 8);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(162, 20);
            this.lbFirstName.TabIndex = 33;
            this.lbFirstName.Text = "Current password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(12, 162);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(272, 27);
            this.txtConfirmPassword.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Confirm new password:";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(303, 259);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
    }
}