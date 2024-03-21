namespace PackageCreator
{
    partial class FontControl
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
            groupBox1 = new GroupBox();
            fontNameDropdown = new ComboBox();
            label2 = new Label();
            fontSizeDropdown = new ComboBox();
            label1 = new Label();
            cancelButton = new Button();
            saveButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fontNameDropdown);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(fontSizeDropdown);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 123);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Font";
            // 
            // fontNameDropdown
            // 
            fontNameDropdown.AutoCompleteMode = AutoCompleteMode.Suggest;
            fontNameDropdown.AutoCompleteSource = AutoCompleteSource.ListItems;
            fontNameDropdown.Location = new Point(6, 35);
            fontNameDropdown.Name = "fontNameDropdown";
            fontNameDropdown.Size = new Size(406, 23);
            fontNameDropdown.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 17);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Font Name";
            // 
            // fontSizeDropdown
            // 
            fontSizeDropdown.AutoCompleteMode = AutoCompleteMode.Suggest;
            fontSizeDropdown.AutoCompleteSource = AutoCompleteSource.ListItems;
            fontSizeDropdown.Location = new Point(6, 82);
            fontSizeDropdown.Name = "fontSizeDropdown";
            fontSizeDropdown.Size = new Size(406, 23);
            fontSizeDropdown.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 64);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Font Size";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(222, 236);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(101, 39);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(329, 236);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(101, 39);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // FontControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 287);
            Controls.Add(saveButton);
            Controls.Add(groupBox1);
            Controls.Add(cancelButton);
            MaximizeBox = false;
            MaximumSize = new Size(458, 326);
            MinimizeBox = false;
            MinimumSize = new Size(458, 326);
            Name = "FontControl";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Font Configuration";
            TopMost = true;
            Load += FontControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button cancelButton;
        private ComboBox fontSizeDropdown;
        private Label label1;
        private Button saveButton;
        private ComboBox fontNameDropdown;
        private Label label2;
    }
}