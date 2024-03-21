/**
 * Author: Branden Brideau
 * Date: 3/6/2024
 * 
 * Font control form.
 */

namespace PackageCreator
{
    internal partial class FontControl : Form
    {
        /// <summary>
        /// Font size property.
        /// </summary>
        internal float FontSize { get; set; } = 12;

        /// <summary>
        /// Font name property.
        /// </summary>
        internal string FontName { get; set; } = string.Empty;

        internal FontControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the form is loading.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Arguments of the event.</param>
        private void FontControl_Load(object sender, EventArgs e)
        {
            // Add all sizes
            for (int i = 8; i < 30; i++)
            {
                fontSizeDropdown.Items.Add(i.ToString());
            }

            // Add all fonts families
            foreach (FontFamily font in FontFamily.Families) {
                fontNameDropdown.Items.Add(font.Name);
            }

            // Whatever is set.
            fontSizeDropdown.Text = FontSize.ToString();
            fontNameDropdown.Text = FontName;
        }

        /// <summary>
        /// Called when the user clicks save, which closes the form.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Arguments of the event.</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Parse font size.
            float.TryParse(fontSizeDropdown.Text, out float size);
             
            this.FontSize = (size < 8 ? this.FontSize : size);
            this.FontName = fontNameDropdown.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Called when the user clicks cancel, which closes the form.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Arguments of the event.</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
