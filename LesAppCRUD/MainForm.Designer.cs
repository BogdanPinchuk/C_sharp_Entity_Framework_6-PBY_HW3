using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace LesAppCRUD
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exeFileCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.chouseCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsOMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exeFileOMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseOMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.infoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openPFile = new System.Windows.Forms.OpenFileDialog();
            this.menu.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.infoMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(640, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMenu,
            this.openMenu,
            this.toolStripSeparator1,
            this.closeMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(46, 24);
            this.fileMenu.Text = "File";
            // 
            // createMenu
            // 
            this.createMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentsCMenu,
            this.exeFileCMenu,
            this.chouseCMenu});
            this.createMenu.Name = "createMenu";
            this.createMenu.Size = new System.Drawing.Size(224, 26);
            this.createMenu.Text = "Create";
            this.createMenu.ToolTipText = "Create new DataBase";
            // 
            // documentsCMenu
            // 
            this.documentsCMenu.Name = "documentsCMenu";
            this.documentsCMenu.Size = new System.Drawing.Size(224, 26);
            this.documentsCMenu.Text = "Documents";
            this.documentsCMenu.ToolTipText = "Create DataBase in user\'s Document with standart name (NFSDB)";
            this.documentsCMenu.Click += new System.EventHandler(this.DocumentsCMenu_Click);
            // 
            // exeFileCMenu
            // 
            this.exeFileCMenu.Name = "exeFileCMenu";
            this.exeFileCMenu.Size = new System.Drawing.Size(224, 26);
            this.exeFileCMenu.Text = "Executable file";
            this.exeFileCMenu.ToolTipText = "Create DataBase near exe file with standart name (NFSDB)";
            // 
            // chouseCMenu
            // 
            this.chouseCMenu.Name = "chouseCMenu";
            this.chouseCMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.chouseCMenu.Size = new System.Drawing.Size(224, 26);
            this.chouseCMenu.Text = "Choose";
            this.chouseCMenu.ToolTipText = "You can create DataBase in own directory";
            // 
            // openMenu
            // 
            this.openMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentsOMenu,
            this.exeFileOMenu,
            this.chooseOMenu});
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(224, 26);
            this.openMenu.Text = "Open";
            this.openMenu.ToolTipText = "Open DataBase";
            // 
            // documentsOMenu
            // 
            this.documentsOMenu.Name = "documentsOMenu";
            this.documentsOMenu.Size = new System.Drawing.Size(194, 26);
            this.documentsOMenu.Text = "Documents";
            this.documentsOMenu.ToolTipText = "Open DataBase in user\'s Document with standart name (NFSDB)";
            // 
            // exeFileOMenu
            // 
            this.exeFileOMenu.Name = "exeFileOMenu";
            this.exeFileOMenu.Size = new System.Drawing.Size(194, 26);
            this.exeFileOMenu.Text = "Executable file";
            this.exeFileOMenu.ToolTipText = "Open DataBase near exe file with standart name (NFSDB)";
            // 
            // chooseOMenu
            // 
            this.chooseOMenu.Name = "chooseOMenu";
            this.chooseOMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.chooseOMenu.Size = new System.Drawing.Size(194, 26);
            this.chooseOMenu.Text = "Choose";
            this.chooseOMenu.ToolTipText = "You can open DataBase from own directory";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // closeMenu
            // 
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeMenu.Size = new System.Drawing.Size(224, 26);
            this.closeMenu.Text = "Close";
            this.closeMenu.ToolTipText = "Close program";
            this.closeMenu.Click += new System.EventHandler(this.CloseMenu_Click);
            // 
            // infoMenu
            // 
            this.infoMenu.Name = "infoMenu";
            this.infoMenu.Size = new System.Drawing.Size(49, 24);
            this.infoMenu.Text = "Info";
            this.infoMenu.Click += new System.EventHandler(this.InfoMenu_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 300);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(640, 26);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "Info";
            // 
            // infoLabel
            // 
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(73, 20);
            this.infoLabel.Text = "File name";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 28);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer.Panel1.ContextMenuStrip = this.contextMenu;
            this.splitContainer.Panel1.Controls.Add(this.pictureBox);
            this.toolTip.SetToolTip(this.splitContainer.Panel1, "Poster of game");
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer.Size = new System.Drawing.Size(640, 272);
            this.splitContainer.SplitterDistance = 213;
            this.splitContainer.TabIndex = 2;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMenu,
            this.deleteMenu});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(123, 52);
            // 
            // loadMenu
            // 
            this.loadMenu.Name = "loadMenu";
            this.loadMenu.Size = new System.Drawing.Size(122, 24);
            this.loadMenu.Text = "Load";
            this.loadMenu.ToolTipText = "Load image";
            this.loadMenu.Click += new System.EventHandler(this.LoadMenu_Click);
            // 
            // deleteMenu
            // 
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Size = new System.Drawing.Size(122, 24);
            this.deleteMenu.Text = "Delete";
            this.deleteMenu.ToolTipText = "Delete inage";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(213, 272);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox, "Poster");
            // 
            // openPFile
            // 
            this.openPFile.FileName = "Picture";
            this.openPFile.Filter = "JPEG (*.jpeg, *.jpg)|*.jpeg; *.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp|TIFF (*.ti" +
    "f, *.tiff)|*.tif; *.tiff|GIF (*.gif)|*.gif|All files|*.*";
            this.openPFile.Title = "Load image";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 326);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "CRUD NFS";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem createMenu;
        private ToolStripMenuItem openMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem closeMenu;
        private StatusStrip statusBar;
        private ToolStripStatusLabel infoLabel;
        private ToolStripMenuItem infoMenu;
        private ToolStripMenuItem documentsCMenu;
        private ToolStripMenuItem exeFileCMenu;
        private ToolStripMenuItem chouseCMenu;
        private ToolStripMenuItem documentsOMenu;
        private ToolStripMenuItem exeFileOMenu;
        private ToolStripMenuItem chooseOMenu;
        private ToolTip toolTip;
        private SplitContainer splitContainer;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem loadMenu;
        private ToolStripMenuItem deleteMenu;
        private OpenFileDialog openPFile;
        private PictureBox pictureBox;
    }
}

