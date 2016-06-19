namespace ir
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbCyr = new System.Windows.Forms.RichTextBox();
            this.CyrContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCopyCyr = new System.Windows.Forms.ToolStripMenuItem();
            this.tbLat = new System.Windows.Forms.RichTextBox();
            this.LatContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCopyLat = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCyr = new System.Windows.Forms.GroupBox();
            this.gbLat = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файл = new System.Windows.Forms.ToolStripMenuItem();
            this.æддæмæToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.æрмадз = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSoviet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.кириллагæйЛатинагмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.латинагæйКириллагмæToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.истыТекстСæвæрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бæрæг = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tspCyrLat = new System.Windows.Forms.ToolStripMenuItem();
            this.tspLatCyr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbSoviet = new System.Windows.Forms.RadioButton();
            this.rbVaso = new System.Windows.Forms.RadioButton();
            this.rbKudar = new System.Windows.Forms.RadioButton();
            this.menuKudar = new System.Windows.Forms.ToolStripMenuItem();
            this.LatContextMenuStrip.SuspendLayout();
            this.gbCyr.SuspendLayout();
            this.gbLat.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCyr
            // 
            this.tbCyr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCyr.BackColor = System.Drawing.Color.Snow;
            this.tbCyr.ContextMenuStrip = this.CyrContextMenuStrip;
            this.tbCyr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCyr.ForeColor = System.Drawing.Color.Black;
            this.tbCyr.Location = new System.Drawing.Point(6, 19);
            this.tbCyr.Name = "tbCyr";
            this.tbCyr.Size = new System.Drawing.Size(671, 169);
            this.tbCyr.TabIndex = 0;
            this.tbCyr.Text = "";
            this.tbCyr.TextChanged += new System.EventHandler(this.tbCyr_TextChanged);
            // 
            // CyrContextMenuStrip
            // 
            this.CyrContextMenuStrip.Name = "contextMenuStrip1";
            this.CyrContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // tsCopyCyr
            // 
            this.tsCopyCyr.Name = "tsCopyCyr";
            this.tsCopyCyr.Size = new System.Drawing.Size(152, 22);
            this.tsCopyCyr.Text = "Копировать";
            this.tsCopyCyr.Click += new System.EventHandler(this.tsCopyCyr_Click);
            // 
            // tbLat
            // 
            this.tbLat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLat.BackColor = System.Drawing.Color.MintCream;
            this.tbLat.ContextMenuStrip = this.LatContextMenuStrip;
            this.tbLat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLat.ForeColor = System.Drawing.Color.Black;
            this.tbLat.Location = new System.Drawing.Point(6, 19);
            this.tbLat.Name = "tbLat";
            this.tbLat.ReadOnly = true;
            this.tbLat.Size = new System.Drawing.Size(671, 177);
            this.tbLat.TabIndex = 1;
            this.tbLat.Text = "";
            this.tbLat.TextChanged += new System.EventHandler(this.tbLat_TextChanged);
            // 
            // LatContextMenuStrip
            // 
            this.LatContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCopyLat});
            this.LatContextMenuStrip.Name = "LatContextMenuStrip";
            this.LatContextMenuStrip.Size = new System.Drawing.Size(140, 26);
            // 
            // tsCopyLat
            // 
            this.tsCopyLat.Name = "tsCopyLat";
            this.tsCopyLat.Size = new System.Drawing.Size(139, 22);
            this.tsCopyLat.Text = "Копировать";
            this.tsCopyLat.Click += new System.EventHandler(this.tsCopyLat_Click);
            // 
            // gbCyr
            // 
            this.gbCyr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCyr.Controls.Add(this.tbCyr);
            this.gbCyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCyr.Location = new System.Drawing.Point(3, 3);
            this.gbCyr.Name = "gbCyr";
            this.gbCyr.Size = new System.Drawing.Size(683, 201);
            this.gbCyr.TabIndex = 6;
            this.gbCyr.TabStop = false;
            this.gbCyr.Text = "Кириллаг текстæй";
            // 
            // gbLat
            // 
            this.gbLat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLat.Controls.Add(this.tbLat);
            this.gbLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbLat.Location = new System.Drawing.Point(3, 210);
            this.gbLat.Name = "gbLat";
            this.gbLat.Size = new System.Drawing.Size(683, 202);
            this.gbLat.TabIndex = 7;
            this.gbLat.TabStop = false;
            this.gbLat.Text = "Latinag tekstmæ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файл,
            this.æрмадз,
            this.бæрæг});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файл
            // 
            this.файл.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.æддæмæToolStripMenuItem});
            this.файл.Name = "файл";
            this.файл.Size = new System.Drawing.Size(48, 20);
            this.файл.Text = "Файл";
            // 
            // æддæмæToolStripMenuItem
            // 
            this.æддæмæToolStripMenuItem.Name = "æддæмæToolStripMenuItem";
            this.æддæмæToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.æддæмæToolStripMenuItem.Text = "Æддæмæ";
            this.æддæмæToolStripMenuItem.Click += new System.EventHandler(this.æддæмæToolStripMenuItem_Click);
            // 
            // æрмадз
            // 
            this.æрмадз.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.menuSoviet,
            this.menuKudar,
            this.кириллагæйЛатинагмToolStripMenuItem,
            this.латинагæйКириллагмæToolStripMenuItem,
            this.toolStripSeparator2,
            this.истыТекстСæвæрToolStripMenuItem});
            this.æрмадз.Name = "æрмадз";
            this.æрмадз.Size = new System.Drawing.Size(62, 20);
            this.æрмадз.Text = "Æрмадз";
            // 
            // menuSoviet
            // 
            this.menuSoviet.Name = "menuSoviet";
            this.menuSoviet.Size = new System.Drawing.Size(226, 22);
            this.menuSoviet.Text = "20-æм азы дамгъуат";
            this.menuSoviet.Click += new System.EventHandler(this.menuSoviet_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(226, 22);
            this.toolStripMenuItem2.Text = "Абайты Васойы дамгъуат";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.menuVaso_Click);
            // 
            // кириллагæйЛатинагмToolStripMenuItem
            // 
            this.кириллагæйЛатинагмToolStripMenuItem.Name = "кириллагæйЛатинагмToolStripMenuItem";
            this.кириллагæйЛатинагмToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.кириллагæйЛатинагмToolStripMenuItem.Text = "Кириллагæй -> Латинагмæ";
            this.кириллагæйЛатинагмToolStripMenuItem.Visible = false;
            this.кириллагæйЛатинагмToolStripMenuItem.Click += new System.EventHandler(this.кириллагæйЛатинагмToolStripMenuItem_Click);
            // 
            // латинагæйКириллагмæToolStripMenuItem
            // 
            this.латинагæйКириллагмæToolStripMenuItem.Name = "латинагæйКириллагмæToolStripMenuItem";
            this.латинагæйКириллагмæToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.латинагæйКириллагмæToolStripMenuItem.Text = "Латинагæй -> Кириллагмæ";
            this.латинагæйКириллагмæToolStripMenuItem.Visible = false;
            this.латинагæйКириллагмæToolStripMenuItem.Click += new System.EventHandler(this.латинагæйКириллагмæToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
            // 
            // истыТекстСæвæрToolStripMenuItem
            // 
            this.истыТекстСæвæрToolStripMenuItem.Name = "истыТекстСæвæрToolStripMenuItem";
            this.истыТекстСæвæрToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.истыТекстСæвæрToolStripMenuItem.Text = "Исты текст сæвæр";
            this.истыТекстСæвæрToolStripMenuItem.Click += new System.EventHandler(this.истыТекстСæвæрToolStripMenuItem_Click);
            // 
            // бæрæг
            // 
            this.бæрæг.Name = "бæрæг";
            this.бæрæг.Size = new System.Drawing.Size(58, 20);
            this.бæрæг.Text = "Бæрæг";
            this.бæрæг.Click += new System.EventHandler(this.бæрæг_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQuit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmQuit
            // 
            this.tsmQuit.Name = "tsmQuit";
            this.tsmQuit.Size = new System.Drawing.Size(125, 22);
            this.tsmQuit.Text = "Æддæмæ";
            // 
            // tsmSettings
            // 
            this.tsmSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspCyrLat,
            this.tspLatCyr,
            this.toolStripSeparator1,
            this.tsmRandom});
            this.tsmSettings.Name = "tsmSettings";
            this.tsmSettings.Size = new System.Drawing.Size(62, 20);
            this.tsmSettings.Text = "Æрмадз";
            // 
            // tspCyrLat
            // 
            this.tspCyrLat.Name = "tspCyrLat";
            this.tspCyrLat.Size = new System.Drawing.Size(226, 22);
            this.tspCyrLat.Text = "Кириллагæй -> Латинагмæ";
            // 
            // tspLatCyr
            // 
            this.tspLatCyr.Name = "tspLatCyr";
            this.tspLatCyr.Size = new System.Drawing.Size(226, 22);
            this.tspLatCyr.Text = "Латинагæй -> Кириллагмæ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // tsmRandom
            // 
            this.tsmRandom.Name = "tsmRandom";
            this.tsmRandom.Size = new System.Drawing.Size(226, 22);
            this.tsmRandom.Text = "Исты текст сæвæр";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(58, 20);
            this.tsmAbout.Text = "Бæрæг";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbLat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbCyr, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 415);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // rbSoviet
            // 
            this.rbSoviet.AutoSize = true;
            this.rbSoviet.Checked = true;
            this.rbSoviet.Location = new System.Drawing.Point(174, 27);
            this.rbSoviet.Name = "rbSoviet";
            this.rbSoviet.Size = new System.Drawing.Size(141, 17);
            this.rbSoviet.TabIndex = 10;
            this.rbSoviet.TabStop = true;
            this.rbSoviet.Text = "20-æм æзты дамгъуат";
            this.rbSoviet.UseVisualStyleBackColor = true;
            this.rbSoviet.CheckedChanged += new System.EventHandler(this.rbSoviet_CheckedChanged);
            // 
            // rbVaso
            // 
            this.rbVaso.AutoSize = true;
            this.rbVaso.Location = new System.Drawing.Point(12, 27);
            this.rbVaso.Name = "rbVaso";
            this.rbVaso.Size = new System.Drawing.Size(156, 17);
            this.rbVaso.TabIndex = 11;
            this.rbVaso.Text = "Абайты Васойы дамгъуат";
            this.rbVaso.UseVisualStyleBackColor = true;
            this.rbVaso.CheckedChanged += new System.EventHandler(this.rbVaso_CheckedChanged);
            // 
            // rbKudar
            // 
            this.rbKudar.AutoSize = true;
            this.rbKudar.Location = new System.Drawing.Point(321, 27);
            this.rbKudar.Name = "rbKudar";
            this.rbKudar.Size = new System.Drawing.Size(128, 17);
            this.rbKudar.TabIndex = 12;
            this.rbKudar.Text = "Къуыдайрагау (beta)";
            this.rbKudar.UseVisualStyleBackColor = true;
            this.rbKudar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // menuKudar
            // 
            this.menuKudar.Name = "menuKudar";
            this.menuKudar.Size = new System.Drawing.Size(226, 22);
            this.menuKudar.Text = "Къуыдайрагау (beta)";
            this.menuKudar.Click += new System.EventHandler(this.menuKudar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(713, 477);
            this.Controls.Add(this.rbKudar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.rbVaso);
            this.Controls.Add(this.rbSoviet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИрTranslit v 1.1";
            this.LatContextMenuStrip.ResumeLayout(false);
            this.gbCyr.ResumeLayout(false);
            this.gbLat.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbCyr;
        private System.Windows.Forms.RichTextBox tbLat;
        private System.Windows.Forms.GroupBox gbCyr;
        private System.Windows.Forms.GroupBox gbLat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmRandom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tspCyrLat;
        private System.Windows.Forms.ToolStripMenuItem tspLatCyr;
        private System.Windows.Forms.ContextMenuStrip CyrContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsCopyCyr;
        private System.Windows.Forms.ContextMenuStrip LatContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsCopyLat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem файл;
        private System.Windows.Forms.ToolStripMenuItem æрмадз;
        private System.Windows.Forms.ToolStripMenuItem бæрæг;
        private System.Windows.Forms.ToolStripMenuItem æддæмæToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кириллагæйЛатинагмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem латинагæйКириллагмæToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem истыТекстСæвæрToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbSoviet;
        private System.Windows.Forms.RadioButton rbVaso;
        private System.Windows.Forms.ToolStripMenuItem menuSoviet;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.RadioButton rbKudar;
        private System.Windows.Forms.ToolStripMenuItem menuKudar;
    }
}

