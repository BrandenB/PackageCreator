namespace PackageCreator
{
    partial class PackageCreator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            generateJSONToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            exportPackageToolStripMenuItem = new ToolStripMenuItem();
            k1000ToolStripMenuItem = new ToolStripMenuItem();
            intuneToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            copyToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            fontToolStripMenuItem = new ToolStripMenuItem();
            errorProvider = new ErrorProvider(components);
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            detectionScript = new RichTextBox();
            label7 = new Label();
            uninstallCommand = new TextBox();
            label5 = new Label();
            installCommand = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            appType = new ComboBox();
            label6 = new Label();
            appInstallParams = new TextBox();
            label3 = new Label();
            appLocation = new TextBox();
            label2 = new Label();
            appVersion = new TextBox();
            labelVersion = new Label();
            appName = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            jsonRichBox = new RichTextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1480, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator2, generateJSONToolStripMenuItem, toolStripMenuItem2, exportPackageToolStripMenuItem, toolStripSeparator1, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(195, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(195, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(195, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(192, 6);
            // 
            // generateJSONToolStripMenuItem
            // 
            generateJSONToolStripMenuItem.Enabled = false;
            generateJSONToolStripMenuItem.Name = "generateJSONToolStripMenuItem";
            generateJSONToolStripMenuItem.Size = new Size(195, 22);
            generateJSONToolStripMenuItem.Text = "Generate JSON";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(192, 6);
            // 
            // exportPackageToolStripMenuItem
            // 
            exportPackageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { k1000ToolStripMenuItem, intuneToolStripMenuItem });
            exportPackageToolStripMenuItem.Name = "exportPackageToolStripMenuItem";
            exportPackageToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exportPackageToolStripMenuItem.Size = new Size(195, 22);
            exportPackageToolStripMenuItem.Text = "Create Package";
            // 
            // k1000ToolStripMenuItem
            // 
            k1000ToolStripMenuItem.Name = "k1000ToolStripMenuItem";
            k1000ToolStripMenuItem.Size = new Size(108, 22);
            k1000ToolStripMenuItem.Text = "K1000";
            // 
            // intuneToolStripMenuItem
            // 
            intuneToolStripMenuItem.Name = "intuneToolStripMenuItem";
            intuneToolStripMenuItem.Size = new Size(108, 22);
            intuneToolStripMenuItem.Text = "Intune";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(192, 6);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(195, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, toolStripSeparator3, copyToolStripMenuItem, cutToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, fontToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(170, 22);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(167, 6);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(170, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(170, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(170, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(167, 6);
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            fontToolStripMenuItem.Size = new Size(170, 22);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Title = "Save as";
            // 
            // openFileDialog
            // 
            openFileDialog.Title = "Open";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1487, 766);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1479, 738);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Single Application";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(detectionScript);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(uninstallCommand);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(installCommand);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(11, 297);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1456, 428);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information for Installation";
            // 
            // detectionScript
            // 
            detectionScript.Anchor = AnchorStyles.None;
            detectionScript.Location = new Point(15, 140);
            detectionScript.Name = "detectionScript";
            detectionScript.ReadOnly = true;
            detectionScript.Size = new Size(1428, 269);
            detectionScript.TabIndex = 13;
            detectionScript.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 123);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 12;
            label7.Text = "Detection Script";
            // 
            // uninstallCommand
            // 
            uninstallCommand.Anchor = AnchorStyles.None;
            uninstallCommand.BorderStyle = BorderStyle.FixedSingle;
            uninstallCommand.Location = new Point(15, 91);
            uninstallCommand.Name = "uninstallCommand";
            uninstallCommand.Size = new Size(1428, 23);
            uninstallCommand.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 74);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 10;
            label5.Text = "Uninstall Command";
            // 
            // installCommand
            // 
            installCommand.Anchor = AnchorStyles.None;
            installCommand.BorderStyle = BorderStyle.FixedSingle;
            installCommand.Location = new Point(15, 47);
            installCommand.Name = "installCommand";
            installCommand.Size = new Size(1428, 23);
            installCommand.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 29);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 8;
            label4.Text = "Install Command";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(appType);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(appInstallParams);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(appLocation);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(appVersion);
            groupBox1.Controls.Add(labelVersion);
            groupBox1.Controls.Add(appName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1456, 269);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Package Information";
            // 
            // appType
            // 
            appType.Anchor = AnchorStyles.None;
            appType.FormattingEnabled = true;
            appType.Items.AddRange(new object[] { "exe", "msi", "msix" });
            appType.Location = new Point(15, 234);
            appType.Name = "appType";
            appType.Size = new Size(1428, 23);
            appType.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(15, 216);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 8;
            label6.Text = "App Type";
            // 
            // appInstallParams
            // 
            appInstallParams.Anchor = AnchorStyles.None;
            appInstallParams.BorderStyle = BorderStyle.FixedSingle;
            appInstallParams.Location = new Point(15, 183);
            appInstallParams.Name = "appInstallParams";
            appInstallParams.Size = new Size(1428, 23);
            appInstallParams.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 165);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 6;
            label3.Text = "App Installation Parameters";
            // 
            // appLocation
            // 
            appLocation.Anchor = AnchorStyles.None;
            appLocation.BorderStyle = BorderStyle.FixedSingle;
            appLocation.Location = new Point(15, 137);
            appLocation.Name = "appLocation";
            appLocation.Size = new Size(1428, 23);
            appLocation.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 119);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "App Location";
            // 
            // appVersion
            // 
            appVersion.Anchor = AnchorStyles.None;
            appVersion.BorderStyle = BorderStyle.FixedSingle;
            appVersion.Location = new Point(15, 92);
            appVersion.Name = "appVersion";
            appVersion.Size = new Size(1428, 23);
            appVersion.TabIndex = 3;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(15, 74);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(70, 15);
            labelVersion.TabIndex = 2;
            labelVersion.Text = "App Version";
            // 
            // appName
            // 
            appName.Anchor = AnchorStyles.None;
            appName.BorderStyle = BorderStyle.FixedSingle;
            appName.Location = new Point(15, 48);
            appName.Name = "appName";
            appName.Size = new Size(1428, 23);
            appName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "App Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1479, 738);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Multiple Applications";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(jsonRichBox);
            groupBox3.Location = new Point(8, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1459, 723);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "JSON Package";
            // 
            // jsonRichBox
            // 
            jsonRichBox.Location = new Point(6, 22);
            jsonRichBox.Name = "jsonRichBox";
            jsonRichBox.Size = new Size(1447, 695);
            jsonRichBox.TabIndex = 0;
            jsonRichBox.Text = "";
            // 
            // PackageCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 792);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(1496, 831);
            MinimumSize = new Size(1496, 831);
            Name = "PackageCreator";
            Text = "Package Creator";
            Load += PackageCreator_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem exportPackageToolStripMenuItem;
        private ToolStripMenuItem k1000ToolStripMenuItem;
        private ToolStripMenuItem intuneToolStripMenuItem;
        private ErrorProvider errorProvider;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private RichTextBox detectionScript;
        private Label label7;
        private TextBox uninstallCommand;
        private Label label5;
        private TextBox installCommand;
        private Label label4;
        private GroupBox groupBox1;
        private ComboBox appType;
        private Label label6;
        private TextBox appInstallParams;
        private Label label3;
        private TextBox appLocation;
        private Label label2;
        private TextBox appVersion;
        private Label labelVersion;
        private TextBox appName;
        private Label label1;
        private TabPage tabPage2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem generateJSONToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private GroupBox groupBox3;
        private RichTextBox jsonRichBox;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem fontToolStripMenuItem;
    }
}
