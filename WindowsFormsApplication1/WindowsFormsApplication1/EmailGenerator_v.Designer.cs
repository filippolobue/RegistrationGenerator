namespace WindowsFormsApplication1
{
    partial class EmailGenerator_v
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailGenerator_v));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.asdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.proprietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.langEng = new System.Windows.Forms.ToolStripMenuItem();
            this.langIta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.developedLabel = new System.Windows.Forms.Label();
            this.emailB = new System.Windows.Forms.Button();
            this.fnameB = new System.Windows.Forms.Button();
            this.lnameB = new System.Windows.Forms.Button();
            this.ageB = new System.Windows.Forms.Button();
            this.placeB = new System.Windows.Forms.Button();
            this.passwordB = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.placeLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip2.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdasdToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(131, 30);
            // 
            // asdasdToolStripMenuItem
            // 
            this.asdasdToolStripMenuItem.Name = "asdasdToolStripMenuItem";
            this.asdasdToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.asdasdToolStripMenuItem.Text = "asdasd";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proprietToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(542, 28);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // proprietToolStripMenuItem
            // 
            this.proprietToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.proprietToolStripMenuItem.Name = "proprietToolStripMenuItem";
            this.proprietToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.proprietToolStripMenuItem.Text = "Properties";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langEng,
            this.langIta});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.languageToolStripMenuItem.Text = "language";
            // 
            // langEng
            // 
            this.langEng.Image = global::EmailGenerator.Properties.Resources.tick;
            this.langEng.Name = "langEng";
            this.langEng.Size = new System.Drawing.Size(181, 26);
            this.langEng.Text = "English";
            // 
            // langIta
            // 
            this.langIta.Name = "langIta";
            this.langIta.Size = new System.Drawing.Size(181, 26);
            this.langIta.Text = "Italian";
            this.langIta.Click += new System.EventHandler(this.langIta_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // developedLabel
            // 
            this.developedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.developedLabel.AutoSize = true;
            this.developedLabel.BackColor = System.Drawing.Color.Transparent;
            this.developedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developedLabel.Location = new System.Drawing.Point(-4, 281);
            this.developedLabel.Name = "developedLabel";
            this.developedLabel.Size = new System.Drawing.Size(223, 20);
            this.developedLabel.TabIndex = 4;
            this.developedLabel.Text = "Developed by Filippo Lo Bue";
            // 
            // emailB
            // 
            this.emailB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailB.Location = new System.Drawing.Point(12, 40);
            this.emailB.Name = "emailB";
            this.emailB.Size = new System.Drawing.Size(127, 33);
            this.emailB.TabIndex = 5;
            this.emailB.Text = "Email";
            this.emailB.UseVisualStyleBackColor = true;
            this.emailB.Click += new System.EventHandler(this.emailB_Click);
            // 
            // fnameB
            // 
            this.fnameB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameB.Location = new System.Drawing.Point(12, 79);
            this.fnameB.Name = "fnameB";
            this.fnameB.Size = new System.Drawing.Size(127, 33);
            this.fnameB.TabIndex = 6;
            this.fnameB.Text = "First Name";
            this.fnameB.UseVisualStyleBackColor = true;
            this.fnameB.Click += new System.EventHandler(this.fnameB_Click);
            // 
            // lnameB
            // 
            this.lnameB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameB.Location = new System.Drawing.Point(12, 118);
            this.lnameB.Name = "lnameB";
            this.lnameB.Size = new System.Drawing.Size(127, 33);
            this.lnameB.TabIndex = 7;
            this.lnameB.Text = "Last Name";
            this.lnameB.UseVisualStyleBackColor = true;
            this.lnameB.Click += new System.EventHandler(this.lnameB_Click);
            // 
            // ageB
            // 
            this.ageB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageB.Location = new System.Drawing.Point(12, 196);
            this.ageB.Name = "ageB";
            this.ageB.Size = new System.Drawing.Size(127, 33);
            this.ageB.TabIndex = 8;
            this.ageB.Text = "Age";
            this.ageB.UseVisualStyleBackColor = true;
            this.ageB.Click += new System.EventHandler(this.ageB_Click);
            // 
            // placeB
            // 
            this.placeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeB.Location = new System.Drawing.Point(12, 235);
            this.placeB.Name = "placeB";
            this.placeB.Size = new System.Drawing.Size(127, 33);
            this.placeB.TabIndex = 9;
            this.placeB.Text = "City";
            this.placeB.UseVisualStyleBackColor = true;
            this.placeB.Click += new System.EventHandler(this.placeB_Click);
            // 
            // passwordB
            // 
            this.passwordB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordB.Location = new System.Drawing.Point(12, 157);
            this.passwordB.Name = "passwordB";
            this.passwordB.Size = new System.Drawing.Size(127, 33);
            this.passwordB.TabIndex = 10;
            this.passwordB.Text = "Password";
            this.passwordB.UseVisualStyleBackColor = true;
            this.passwordB.Click += new System.EventHandler(this.passwordB_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(160, 46);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(25, 24);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "...";
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLabel.Location = new System.Drawing.Point(160, 85);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(25, 24);
            this.fnameLabel.TabIndex = 12;
            this.fnameLabel.Text = "...";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLabel.Location = new System.Drawing.Point(160, 124);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(25, 24);
            this.lnameLabel.TabIndex = 13;
            this.lnameLabel.Text = "...";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(160, 163);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(25, 24);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "...";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(160, 202);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(25, 24);
            this.ageLabel.TabIndex = 15;
            this.ageLabel.Text = "...";
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeLabel.Location = new System.Drawing.Point(160, 241);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(25, 24);
            this.placeLabel.TabIndex = 16;
            this.placeLabel.Text = "...";
            // 
            // EmailGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(50, 50);
            this.ClientSize = new System.Drawing.Size(542, 301);
            this.Controls.Add(this.placeLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordB);
            this.Controls.Add(this.placeB);
            this.Controls.Add(this.ageB);
            this.Controls.Add(this.lnameB);
            this.Controls.Add(this.fnameB);
            this.Controls.Add(this.emailB);
            this.Controls.Add(this.developedLabel);
            this.Controls.Add(this.menu);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(560, 500);
            this.MinimumSize = new System.Drawing.Size(55, 348);
            this.Name = "EmailGenerator";
            this.Text = "EmailGenerator";
            this.contextMenuStrip2.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem asdasdToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem proprietToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label developedLabel;
        private System.Windows.Forms.Button emailB;
        private System.Windows.Forms.Button fnameB;
        private System.Windows.Forms.Button lnameB;
        private System.Windows.Forms.Button ageB;
        private System.Windows.Forms.Button placeB;
        private System.Windows.Forms.Button passwordB;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem langIta;
        public System.Windows.Forms.ToolStripMenuItem langEng;
    }
}