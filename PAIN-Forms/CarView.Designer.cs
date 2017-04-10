namespace PAIN_Forms
{
    partial class CarView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prędkość = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rok_prod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rodzaj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarTypesImages = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciezarowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jednośladToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.EditContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Edytuj = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuń = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobowyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ciężarowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jednośladToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.EditContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 270);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Marka,
            this.Prędkość,
            this.Rok_prod,
            this.Rodzaj});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.CarTypesImages;
            this.listView1.Location = new System.Drawing.Point(3, 41);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(595, 227);
            this.listView1.SmallImageList = this.CarTypesImages;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseClick);
            // 
            // CarTypesImages
            // 
            this.CarTypesImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("CarTypesImages.ImageStream")));
            this.CarTypesImages.TransparentColor = System.Drawing.Color.Transparent;
            this.CarTypesImages.Images.SetKeyName(0, "osobowka.png");
            this.CarTypesImages.Images.SetKeyName(1, "ciezarowka.png");
            this.CarTypesImages.Images.SetKeyName(2, "rower.png");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(593, 31);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtr:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.comboBox1, 2);
            this.comboBox1.DisplayMember = "0";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Before 2000r",
            "After 2000r"});
            this.comboBox1.Location = new System.Drawing.Point(201, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(388, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(601, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fileToolStripMenuItem.Text = "Widok";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.dataToolStripMenuItem.Text = "Dane";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobowyToolStripMenuItem,
            this.ciezarowyToolStripMenuItem,
            this.jednośladToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // osobowyToolStripMenuItem
            // 
            this.osobowyToolStripMenuItem.Name = "osobowyToolStripMenuItem";
            this.osobowyToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.osobowyToolStripMenuItem.Text = "Osobowy";
            this.osobowyToolStripMenuItem.Click += new System.EventHandler(this.osobowyToolStripMenuItem_Click);
            // 
            // ciezarowyToolStripMenuItem
            // 
            this.ciezarowyToolStripMenuItem.Name = "ciezarowyToolStripMenuItem";
            this.ciezarowyToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ciezarowyToolStripMenuItem.Text = "Ciezarowy";
            this.ciezarowyToolStripMenuItem.Click += new System.EventHandler(this.ciezarowyToolStripMenuItem_Click);
            // 
            // jednośladToolStripMenuItem
            // 
            this.jednośladToolStripMenuItem.Name = "jednośladToolStripMenuItem";
            this.jednośladToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.jednośladToolStripMenuItem.Text = "Jednoślad";
            this.jednośladToolStripMenuItem.Click += new System.EventHandler(this.jednośladToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 273);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(601, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "0";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabel1.Text = "0";
            this.toolStripStatusLabel1.TextChanged += new System.EventHandler(this.toolStripStatusLabel1_TextChanged);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(92, 20);
            this.toolStripStatusLabel2.Text = "Cars showed";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // EditContextMenu
            // 
            this.EditContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edytuj,
            this.Usuń,
            this.nowyToolStripMenuItem});
            this.EditContextMenu.Name = "EditContextMenu";
            this.EditContextMenu.Size = new System.Drawing.Size(182, 110);
            // 
            // Edytuj
            // 
            this.Edytuj.Name = "Edytuj";
            this.Edytuj.Size = new System.Drawing.Size(181, 26);
            this.Edytuj.Text = "Edytuj";
            this.Edytuj.Click += new System.EventHandler(this.Edytuj_Click);
            // 
            // Usuń
            // 
            this.Usuń.Name = "Usuń";
            this.Usuń.Size = new System.Drawing.Size(181, 26);
            this.Usuń.Text = "Usuń";
            this.Usuń.Click += new System.EventHandler(this.Usuń_Click);
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobowyToolStripMenuItem1,
            this.ciężarowyToolStripMenuItem,
            this.jednośladToolStripMenuItem1});
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.nowyToolStripMenuItem.Text = "Nowy";
            // 
            // osobowyToolStripMenuItem1
            // 
            this.osobowyToolStripMenuItem1.Name = "osobowyToolStripMenuItem1";
            this.osobowyToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.osobowyToolStripMenuItem1.Text = "Osobowy";
            this.osobowyToolStripMenuItem1.Click += new System.EventHandler(this.osobowyToolStripMenuItem1_Click);
            // 
            // ciężarowyToolStripMenuItem
            // 
            this.ciężarowyToolStripMenuItem.Name = "ciężarowyToolStripMenuItem";
            this.ciężarowyToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ciężarowyToolStripMenuItem.Text = "Ciężarowy";
            this.ciężarowyToolStripMenuItem.Click += new System.EventHandler(this.ciężarowyToolStripMenuItem_Click);
            // 
            // jednośladToolStripMenuItem1
            // 
            this.jednośladToolStripMenuItem1.Name = "jednośladToolStripMenuItem1";
            this.jednośladToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.jednośladToolStripMenuItem1.Text = "Jednoślad";
            this.jednośladToolStripMenuItem1.Click += new System.EventHandler(this.jednośladToolStripMenuItem1_Click);
            // 
            // CarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 298);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CarView";
            this.Text = "CarView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarView_FormClosing);
            this.Load += new System.EventHandler(this.CarView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.EditContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ColumnHeader Prędkość;
        private System.Windows.Forms.ColumnHeader Rok_prod;
        private System.Windows.Forms.ColumnHeader Rodzaj;
        private System.Windows.Forms.ImageList CarTypesImages;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciezarowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jednośladToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ContextMenuStrip EditContextMenu;
        private System.Windows.Forms.ToolStripMenuItem Edytuj;
        private System.Windows.Forms.ToolStripMenuItem Usuń;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobowyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ciężarowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jednośladToolStripMenuItem1;
    }
}