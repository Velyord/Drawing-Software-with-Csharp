namespace Draw
{
	partial class MainForm
	{
        /// <summary>
        ///  Дизайнерска променлива, използвана за следене на невизуални компоненти.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Разполага ресурси, използвани от формата.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

        /// <summary>
        /// Този метод е необходим за поддръжката на дизайнера на Windows Forms.
        /// Не променяйте съдържанието на метода в редактора на изходния код. Дизайнерът на Forms може
        /// не може да зареди този метод, ако е променен ръчно.
        /// </summary>
        private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.colorDialog4 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.drawRectangleButton = new System.Windows.Forms.ToolStripButton();
            this.drawTriangleButton = new System.Windows.Forms.ToolStripButton();
            this.drawEllipseButton = new System.Windows.Forms.ToolStripButton();
            this.drawLineButton = new System.Windows.Forms.ToolStripButton();
            this.deselectAllButton = new System.Windows.Forms.ToolStripButton();
            this.selectAllButton = new System.Windows.Forms.ToolStripButton();
            this.drawSquareButton = new System.Windows.Forms.ToolStripButton();
            this.drawCircleButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.pickUpButton = new System.Windows.Forms.ToolStripButton();
            this.trasperancyButton = new System.Windows.Forms.ToolStripButton();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.PenButton = new System.Windows.Forms.ToolStripButton();
            this.PenColorButton = new System.Windows.Forms.ToolStripButton();
            this.EraserButton = new System.Windows.Forms.ToolStripButton();
            this.PenSizeButton = new System.Windows.Forms.ToolStripButton();
            this.SizeTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillColorButton = new System.Windows.Forms.ToolStripButton();
            this.borderColorButton = new System.Windows.Forms.ToolStripButton();
            this.bucketButton = new System.Windows.Forms.ToolStripButton();
            this.UndoButton = new System.Windows.Forms.ToolStripButton();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.statusBar.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 1002);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusBar.Size = new System.Drawing.Size(1898, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newFileToolStripMenuItem.Image")));
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.newFileToolStripMenuItem.Text = "New";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripMenuItem.Image")));
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.openFileToolStripMenuItem.Text = "Open";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.polygonToolStripMenuItem,
            this.lineToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            this.newToolStripMenuItem.Text = "New Shape";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.drawRectangleButton_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.drawSquareButton_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.drawEllipseButton_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.drawCircleButton_Click);
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.polygonToolStripMenuItem.Text = "Polygon";
            this.polygonToolStripMenuItem.Click += new System.EventHandler(this.drawTriangleButton_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.L)));
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.drawLineButton_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // deselectAllToolStripMenuItem1
            // 
            this.deselectAllToolStripMenuItem1.Name = "deselectAllToolStripMenuItem1";
            this.deselectAllToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deselectAllToolStripMenuItem1.Size = new System.Drawing.Size(269, 34);
            this.deselectAllToolStripMenuItem1.Text = "Deselect All";
            this.deselectAllToolStripMenuItem1.Click += new System.EventHandler(this.deselectAllButton_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(269, 34);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // mainMenu
            // 
            this.mainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1898, 33);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // drawRectangleButton
            // 
            this.drawRectangleButton.BackColor = System.Drawing.SystemColors.Control;
            this.drawRectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.drawRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleButton.Image")));
            this.drawRectangleButton.ImageTransparentColor = System.Drawing.Color.DarkViolet;
            this.drawRectangleButton.Name = "drawRectangleButton";
            this.drawRectangleButton.Size = new System.Drawing.Size(34, 34);
            this.drawRectangleButton.Text = "Rectangle";
            this.drawRectangleButton.Click += new System.EventHandler(this.drawRectangleButton_Click);
            // 
            // drawTriangleButton
            // 
            this.drawTriangleButton.BackColor = System.Drawing.SystemColors.Control;
            this.drawTriangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawTriangleButton.Image = ((System.Drawing.Image)(resources.GetObject("drawTriangleButton.Image")));
            this.drawTriangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawTriangleButton.Name = "drawTriangleButton";
            this.drawTriangleButton.Size = new System.Drawing.Size(34, 34);
            this.drawTriangleButton.Text = "Triangle";
            this.drawTriangleButton.Click += new System.EventHandler(this.drawTriangleButton_Click);
            // 
            // drawEllipseButton
            // 
            this.drawEllipseButton.BackColor = System.Drawing.SystemColors.Control;
            this.drawEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseButton.Image")));
            this.drawEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseButton.Name = "drawEllipseButton";
            this.drawEllipseButton.Size = new System.Drawing.Size(34, 34);
            this.drawEllipseButton.Text = "Ellipse";
            this.drawEllipseButton.Click += new System.EventHandler(this.drawEllipseButton_Click);
            // 
            // drawLineButton
            // 
            this.drawLineButton.BackColor = System.Drawing.SystemColors.Control;
            this.drawLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawLineButton.Image = ((System.Drawing.Image)(resources.GetObject("drawLineButton.Image")));
            this.drawLineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawLineButton.Name = "drawLineButton";
            this.drawLineButton.Size = new System.Drawing.Size(34, 34);
            this.drawLineButton.Text = "Line";
            this.drawLineButton.Click += new System.EventHandler(this.drawLineButton_Click);
            // 
            // deselectAllButton
            // 
            this.deselectAllButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.deselectAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deselectAllButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.deselectAllButton.Image = ((System.Drawing.Image)(resources.GetObject("deselectAllButton.Image")));
            this.deselectAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deselectAllButton.Name = "deselectAllButton";
            this.deselectAllButton.Size = new System.Drawing.Size(34, 34);
            this.deselectAllButton.Text = "Deselect All";
            this.deselectAllButton.Click += new System.EventHandler(this.deselectAllButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.selectAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectAllButton.Image = ((System.Drawing.Image)(resources.GetObject("selectAllButton.Image")));
            this.selectAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(34, 34);
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // drawSquareButton
            // 
            this.drawSquareButton.BackColor = System.Drawing.SystemColors.Control;
            this.drawSquareButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawSquareButton.Image = ((System.Drawing.Image)(resources.GetObject("drawSquareButton.Image")));
            this.drawSquareButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawSquareButton.Name = "drawSquareButton";
            this.drawSquareButton.Size = new System.Drawing.Size(34, 34);
            this.drawSquareButton.Text = "Square";
            this.drawSquareButton.Click += new System.EventHandler(this.drawSquareButton_Click);
            // 
            // drawCircleButton
            // 
            this.drawCircleButton.BackColor = System.Drawing.SystemColors.Control;
            this.drawCircleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircleButton.Image = ((System.Drawing.Image)(resources.GetObject("drawCircleButton.Image")));
            this.drawCircleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircleButton.Name = "drawCircleButton";
            this.drawCircleButton.Size = new System.Drawing.Size(34, 34);
            this.drawCircleButton.Text = "Circle";
            this.drawCircleButton.Click += new System.EventHandler(this.drawCircleButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.MergeIndex = 5;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(34, 34);
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // pickUpButton
            // 
            this.pickUpButton.CheckOnClick = true;
            this.pickUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpButton.Image")));
            this.pickUpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpButton.Name = "pickUpButton";
            this.pickUpButton.Size = new System.Drawing.Size(34, 34);
            this.pickUpButton.Text = "Select";
            this.pickUpButton.Click += new System.EventHandler(this.pickUpButton_Click);
            // 
            // trasperancyButton
            // 
            this.trasperancyButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.trasperancyButton.BackColor = System.Drawing.SystemColors.Control;
            this.trasperancyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.trasperancyButton.Image = ((System.Drawing.Image)(resources.GetObject("trasperancyButton.Image")));
            this.trasperancyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.trasperancyButton.Name = "trasperancyButton";
            this.trasperancyButton.Size = new System.Drawing.Size(34, 34);
            this.trasperancyButton.Text = "Transperancy";
            this.trasperancyButton.Click += new System.EventHandler(this.trasperancyButton_Click);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpButton,
            this.PenButton,
            this.PenColorButton,
            this.EraserButton,
            this.PenSizeButton,
            this.SizeTextBox,
            this.drawRectangleButton,
            this.drawSquareButton,
            this.drawEllipseButton,
            this.drawCircleButton,
            this.drawTriangleButton,
            this.drawLineButton,
            this.trasperancyButton,
            this.deleteButton,
            this.deselectAllButton,
            this.selectAllButton,
            this.fillColorButton,
            this.borderColorButton,
            this.bucketButton,
            this.UndoButton});
            this.speedMenu.Location = new System.Drawing.Point(0, 33);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(1898, 39);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // PenButton
            // 
            this.PenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PenButton.Image = ((System.Drawing.Image)(resources.GetObject("PenButton.Image")));
            this.PenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(34, 34);
            this.PenButton.Text = "PenButton";
            this.PenButton.Click += new System.EventHandler(this.PenButton_Click);
            // 
            // PenColorButton
            // 
            this.PenColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PenColorButton.Image = ((System.Drawing.Image)(resources.GetObject("PenColorButton.Image")));
            this.PenColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PenColorButton.Name = "PenColorButton";
            this.PenColorButton.Size = new System.Drawing.Size(34, 34);
            this.PenColorButton.Text = "PenColorButton";
            this.PenColorButton.Click += new System.EventHandler(this.PenColorButton_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EraserButton.Image = ((System.Drawing.Image)(resources.GetObject("EraserButton.Image")));
            this.EraserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(34, 34);
            this.EraserButton.Text = "EraserButton";
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // PenSizeButton
            // 
            this.PenSizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PenSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("PenSizeButton.Image")));
            this.PenSizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PenSizeButton.Name = "PenSizeButton";
            this.PenSizeButton.Size = new System.Drawing.Size(34, 34);
            this.PenSizeButton.Text = "PenSizeButton";
            this.PenSizeButton.Click += new System.EventHandler(this.PenSizeButton_Click);
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(39, 39);
            this.SizeTextBox.Text = "1";
            // 
            // fillColorButton
            // 
            this.fillColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillColorButton.Image = ((System.Drawing.Image)(resources.GetObject("fillColorButton.Image")));
            this.fillColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillColorButton.Name = "fillColorButton";
            this.fillColorButton.Size = new System.Drawing.Size(34, 34);
            this.fillColorButton.Text = "Fill Color";
            this.fillColorButton.Click += new System.EventHandler(this.fillColorButton_Click);
            // 
            // borderColorButton
            // 
            this.borderColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.borderColorButton.Image = ((System.Drawing.Image)(resources.GetObject("borderColorButton.Image")));
            this.borderColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.borderColorButton.Name = "borderColorButton";
            this.borderColorButton.Size = new System.Drawing.Size(34, 34);
            this.borderColorButton.Text = "Border Color";
            this.borderColorButton.ToolTipText = "Border Color";
            this.borderColorButton.Click += new System.EventHandler(this.borderColorButton_Click);
            // 
            // bucketButton
            // 
            this.bucketButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bucketButton.Image = ((System.Drawing.Image)(resources.GetObject("bucketButton.Image")));
            this.bucketButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bucketButton.Name = "bucketButton";
            this.bucketButton.Size = new System.Drawing.Size(34, 34);
            this.bucketButton.Text = "BucketButton";
            this.bucketButton.Click += new System.EventHandler(this.bucketButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(34, 34);
            this.UndoButton.Text = "UndoButton";
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // viewPort
            // 
            this.viewPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPort.AutoSize = true;
            this.viewPort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewPort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewPort.Location = new System.Drawing.Point(0, 72);
            this.viewPort.Margin = new System.Windows.Forms.Padding(0);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(1920, 919);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.statusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Best Drawing Software Ever";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ColorDialog colorDialog4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DoubleBufferedPanel viewPort;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton drawRectangleButton;
        private System.Windows.Forms.ToolStripButton drawTriangleButton;
        private System.Windows.Forms.ToolStripButton drawEllipseButton;
        private System.Windows.Forms.ToolStripButton drawLineButton;
        private System.Windows.Forms.ToolStripButton deselectAllButton;
        private System.Windows.Forms.ToolStripButton selectAllButton;
        private System.Windows.Forms.ToolStripButton drawSquareButton;
        private System.Windows.Forms.ToolStripButton drawCircleButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton pickUpButton;
        private System.Windows.Forms.ToolStripButton trasperancyButton;
        private System.Windows.Forms.ToolStrip speedMenu;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bucketButton;
        private System.Windows.Forms.ToolStripButton borderColorButton;
        private System.Windows.Forms.ToolStripButton fillColorButton;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton PenButton;
        private System.Windows.Forms.ToolStripButton PenColorButton;
        private System.Windows.Forms.ToolStripButton PenSizeButton;
        private System.Windows.Forms.ToolStripTextBox SizeTextBox;
        private System.Windows.Forms.ToolStripButton EraserButton;
        private System.Windows.Forms.ToolStripButton UndoButton;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    }
}
