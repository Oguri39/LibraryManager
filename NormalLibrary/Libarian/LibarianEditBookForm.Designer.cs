namespace NormalLibrary.Libarian
{
    partial class LibarianEditBookForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.checkedListPublisher = new System.Windows.Forms.CheckedListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.checkNew = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.releaseDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.checkListAuthor = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkListGenre = new System.Windows.Forms.CheckedListBox();
            this.txtBookFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumberOfCopies = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberOfPages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.windowTop = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.windowTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(583, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 73;
            this.label10.Text = "Publisher:";
            // 
            // checkedListPublisher
            // 
            this.checkedListPublisher.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListPublisher.FormattingEnabled = true;
            this.checkedListPublisher.Location = new System.Drawing.Point(587, 280);
            this.checkedListPublisher.Name = "checkedListPublisher";
            this.checkedListPublisher.Size = new System.Drawing.Size(120, 302);
            this.checkedListPublisher.TabIndex = 72;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(238, 558);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 558);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 70;
            this.btnAdd.Text = "Edit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(17, 359);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(296, 163);
            this.txtDescription.TabIndex = 69;
            this.txtDescription.Text = "";
            // 
            // checkNew
            // 
            this.checkNew.AutoSize = true;
            this.checkNew.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNew.Location = new System.Drawing.Point(251, 528);
            this.checkNew.Name = "checkNew";
            this.checkNew.Size = new System.Drawing.Size(62, 24);
            this.checkNew.TabIndex = 68;
            this.checkNew.Text = "New";
            this.checkNew.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Release date:";
            // 
            // releaseDate
            // 
            this.releaseDate.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDate.Location = new System.Drawing.Point(17, 143);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(296, 28);
            this.releaseDate.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(450, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "Author:";
            // 
            // checkListAuthor
            // 
            this.checkListAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.checkListAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkListAuthor.FormattingEnabled = true;
            this.checkListAuthor.Location = new System.Drawing.Point(454, 280);
            this.checkListAuthor.Name = "checkListAuthor";
            this.checkListAuthor.Size = new System.Drawing.Size(120, 302);
            this.checkListAuthor.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Genre:";
            // 
            // checkListGenre
            // 
            this.checkListGenre.BackColor = System.Drawing.SystemColors.Control;
            this.checkListGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkListGenre.FormattingEnabled = true;
            this.checkListGenre.Location = new System.Drawing.Point(319, 280);
            this.checkListGenre.Name = "checkListGenre";
            this.checkListGenre.Size = new System.Drawing.Size(120, 302);
            this.checkListGenre.TabIndex = 62;
            // 
            // txtBookFee
            // 
            this.txtBookFee.BackColor = System.Drawing.SystemColors.Info;
            this.txtBookFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookFee.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookFee.Location = new System.Drawing.Point(17, 303);
            this.txtBookFee.Name = "txtBookFee";
            this.txtBookFee.Size = new System.Drawing.Size(296, 27);
            this.txtBookFee.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Book fee:";
            // 
            // txtNumberOfCopies
            // 
            this.txtNumberOfCopies.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumberOfCopies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumberOfCopies.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfCopies.Location = new System.Drawing.Point(16, 250);
            this.txtNumberOfCopies.Name = "txtNumberOfCopies";
            this.txtNumberOfCopies.Size = new System.Drawing.Size(297, 27);
            this.txtNumberOfCopies.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Number of copies:";
            // 
            // txtNumberOfPages
            // 
            this.txtNumberOfPages.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumberOfPages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumberOfPages.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfPages.Location = new System.Drawing.Point(17, 197);
            this.txtNumberOfPages.Name = "txtNumberOfPages";
            this.txtNumberOfPages.Size = new System.Drawing.Size(296, 27);
            this.txtNumberOfPages.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Number of pages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 53;
            this.label1.Text = "Edit book";
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.SystemColors.Info;
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(16, 91);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(297, 27);
            this.txtBookName.TabIndex = 52;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(12, 68);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(60, 20);
            this.lbFirstName.TabIndex = 51;
            this.lbFirstName.Text = "Tittle:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 1);
            this.panel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(705, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // windowTop
            // 
            this.windowTop.BackColor = System.Drawing.Color.Transparent;
            this.windowTop.Controls.Add(this.panel1);
            this.windowTop.Controls.Add(this.btnExit);
            this.windowTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowTop.Location = new System.Drawing.Point(0, 0);
            this.windowTop.Name = "windowTop";
            this.windowTop.Size = new System.Drawing.Size(728, 25);
            this.windowTop.TabIndex = 49;
            this.windowTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowTop_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(728, 1);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Design by Oguri Takeshi";
            // 
            // imgBox
            // 
            this.imgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox.Location = new System.Drawing.Point(453, 68);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(121, 156);
            this.imgBox.TabIndex = 57;
            this.imgBox.TabStop = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelBottom.Controls.Add(this.flowLayoutPanel1);
            this.panelBottom.Controls.Add(this.label5);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 593);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(728, 22);
            this.panelBottom.TabIndex = 50;
            // 
            // LibarianEditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 615);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkedListPublisher);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.checkNew);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkListAuthor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkListGenre);
            this.Controls.Add(this.txtBookFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumberOfCopies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumberOfPages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.windowTop);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibarianEditBookForm";
            this.Text = "LibarianEditBookForm";
            this.Load += new System.EventHandler(this.LibarianEditBookForm_Load);
            this.windowTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox checkedListPublisher;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.CheckBox checkNew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker releaseDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkListAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkListGenre;
        private System.Windows.Forms.TextBox txtBookFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumberOfCopies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberOfPages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel windowTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Panel panelBottom;
    }
}