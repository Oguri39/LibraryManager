namespace NormalLibrary.Libarian
{
    partial class LibarianMain
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.windowTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLibrary = new System.Windows.Forms.TabPage();
            this.dgvLibrary = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPublisher = new System.Windows.Forms.TabPage();
            this.tabAuthor = new System.Windows.Forms.TabPage();
            this.tabGenre = new System.Windows.Forms.TabPage();
            this.tabManager = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            this.windowTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelBottom.Controls.Add(this.flowLayoutPanel1);
            this.panelBottom.Controls.Add(this.label5);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 664);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1244, 22);
            this.panelBottom.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1244, 1);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1097, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Design by Oguri Takeshi";
            // 
            // windowTop
            // 
            this.windowTop.BackColor = System.Drawing.Color.Transparent;
            this.windowTop.Controls.Add(this.panel1);
            this.windowTop.Controls.Add(this.btnMinimize);
            this.windowTop.Controls.Add(this.btnResize);
            this.windowTop.Controls.Add(this.btnExit);
            this.windowTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowTop.Location = new System.Drawing.Point(0, 0);
            this.windowTop.Name = "windowTop";
            this.windowTop.Size = new System.Drawing.Size(1244, 25);
            this.windowTop.TabIndex = 17;
            this.windowTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowTop_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 1);
            this.panel1.TabIndex = 3;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Location = new System.Drawing.Point(1169, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnResize
            // 
            this.btnResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResize.BackColor = System.Drawing.Color.SandyBrown;
            this.btnResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResize.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnResize.FlatAppearance.BorderSize = 0;
            this.btnResize.Location = new System.Drawing.Point(1195, 3);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(20, 20);
            this.btnResize.TabIndex = 1;
            this.btnResize.UseVisualStyleBackColor = false;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(1221, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1244, 639);
            this.panel2.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLibrary);
            this.tabControl1.Controls.Add(this.tabPublisher);
            this.tabControl1.Controls.Add(this.tabAuthor);
            this.tabControl1.Controls.Add(this.tabGenre);
            this.tabControl1.Controls.Add(this.tabManager);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1244, 639);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLibrary
            // 
            this.tabLibrary.Controls.Add(this.panel4);
            this.tabLibrary.Controls.Add(this.panel3);
            this.tabLibrary.Controls.Add(this.dgvLibrary);
            this.tabLibrary.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLibrary.Location = new System.Drawing.Point(4, 22);
            this.tabLibrary.Name = "tabLibrary";
            this.tabLibrary.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibrary.Size = new System.Drawing.Size(1236, 613);
            this.tabLibrary.TabIndex = 0;
            this.tabLibrary.Text = "Library";
            this.tabLibrary.UseVisualStyleBackColor = true;
            // 
            // dgvLibrary
            // 
            this.dgvLibrary.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibrary.Location = new System.Drawing.Point(3, 3);
            this.dgvLibrary.Name = "dgvLibrary";
            this.dgvLibrary.Size = new System.Drawing.Size(1230, 607);
            this.dgvLibrary.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library control";
            // 
            // tabPublisher
            // 
            this.tabPublisher.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPublisher.Location = new System.Drawing.Point(4, 22);
            this.tabPublisher.Name = "tabPublisher";
            this.tabPublisher.Padding = new System.Windows.Forms.Padding(3);
            this.tabPublisher.Size = new System.Drawing.Size(1216, 613);
            this.tabPublisher.TabIndex = 1;
            this.tabPublisher.Text = "Publisher";
            this.tabPublisher.UseVisualStyleBackColor = true;
            // 
            // tabAuthor
            // 
            this.tabAuthor.Location = new System.Drawing.Point(4, 22);
            this.tabAuthor.Name = "tabAuthor";
            this.tabAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuthor.Size = new System.Drawing.Size(1216, 613);
            this.tabAuthor.TabIndex = 2;
            this.tabAuthor.Text = "Author";
            this.tabAuthor.UseVisualStyleBackColor = true;
            // 
            // tabGenre
            // 
            this.tabGenre.Location = new System.Drawing.Point(4, 22);
            this.tabGenre.Name = "tabGenre";
            this.tabGenre.Size = new System.Drawing.Size(1216, 613);
            this.tabGenre.TabIndex = 3;
            this.tabGenre.Text = "Genre";
            this.tabGenre.UseVisualStyleBackColor = true;
            // 
            // tabManager
            // 
            this.tabManager.Location = new System.Drawing.Point(4, 22);
            this.tabManager.Name = "tabManager";
            this.tabManager.Size = new System.Drawing.Size(1216, 613);
            this.tabManager.TabIndex = 4;
            this.tabManager.Text = "Manager";
            this.tabManager.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1230, 38);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 578);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1230, 32);
            this.panel4.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1150, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1054, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(952, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LibarianMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.windowTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibarianMain";
            this.Text = "LibarianMain";
            this.Load += new System.EventHandler(this.LibarianMain_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.windowTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel windowTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLibrary;
        private System.Windows.Forms.TabPage tabPublisher;
        private System.Windows.Forms.TabPage tabAuthor;
        private System.Windows.Forms.TabPage tabGenre;
        private System.Windows.Forms.TabPage tabManager;
        private System.Windows.Forms.DataGridView dgvLibrary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
    }
}