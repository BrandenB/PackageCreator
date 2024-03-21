/**
 * Author: Branden Brideau
 * Date: 3/6/2024
 * 
 * Purpose: Used to automatically create packages for K1000 and Intune without having to do the work everytime.
 */
using System.ComponentModel;
using System.Text.Json;

using PackageCreator.Enums;

namespace PackageCreator
{
    /// <summary>
    /// Class for the form.
    /// </summary>
    public partial class PackageCreator : Form
    {
        /// <summary>
        /// Current opened application.
        /// </summary>
        private Models.Application? application;

        /// <summary>
        /// Class constructor.
        /// </summary>
        public PackageCreator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the form is loaded.
        /// In here we set our basic settings.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Arguments of the event.</param>
        private void PackageCreator_Load(object sender, EventArgs e)
        {
            // File dialog options.
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.AddToRecent = true;
            openFileDialog.OkRequiresInteraction = true;
            openFileDialog.AutoUpgradeEnabled = true;

            // Save file dialog options
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.CheckFileExists = true;
            saveFileDialog.AddExtension = true;
            saveFileDialog.AddToRecent = true;
            saveFileDialog.CheckWriteAccess = true;
            saveFileDialog.AutoUpgradeEnabled = true;

            // Register file open dialog event.
            openFileDialog.FileOk += (object? sender, CancelEventArgs e) =>
            {
                if (!e.Cancel)
                {
                    try
                    {
                        using (Stream stream = openFileDialog.OpenFile())
                        {
                            using (StreamReader reader = new StreamReader(stream))
                            {
                                string data = reader.ReadToEnd();

                                if (data is not null)
                                {
                                    // For multiple apps, no fancy UI for this.
                                    if (data.StartsWith("[") && data.EndsWith("]"))
                                    {
                                        jsonRichBox.Text = data;
                                    }
                                    else
                                    {
                                        application = JsonSerializer.Deserialize<Models.Application>(data);

                                        if (application is not null)
                                        {
                                            // Package information.
                                            appName.Text = application.Name;
                                            appVersion.Text = application.Version;
                                            appLocation.Text = application.Location;
                                            appInstallParams.Text = application.Installation;
                                            appType.Text = application.Type.Get();

                                            // Installation information.
                                            installCommand.Text = application.Provision.InstallCommand;
                                            uninstallCommand.Text = application.Provision.InstallCommand;
                                            detectionScript.Text = application.Provision.DetectionScript;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        // Do something... maybe.
                    }
                    catch (OutOfMemoryException ex)
                    {
                        // Do something... maybe.
                    }
                    catch (IOException ex)
                    {
                        // Do something... maybe.
                    }
                    catch (JsonException ex)
                    {
                        // Do something... maybe.
                    }
                    catch (NotSupportedException ex)
                    {
                        // Do something... maybe.
                    }
                }
            };

            // Register save file dialog
            saveFileDialog.FileOk += (object? sender, CancelEventArgs e) =>
            {

            };
        }

        /// <summary>
        /// Event called when the open file button is pressed.
        /// Used for opening an already created package.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Arguments of the event.</param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        /// <summary>
        /// Event called when the font button is clicked.
        /// Used to set app settings and fonts.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Arguments of the event.</param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontControl fontControl = new())
            {
                fontControl.FontSize = jsonRichBox.Font.Size;
                fontControl.FontName = jsonRichBox.Font.Name;

                if (fontControl.ShowDialog() is DialogResult.OK)
                {
                    jsonRichBox.Font = new Font(fontControl.FontName, fontControl.FontSize);
                }
            }  
        }
    }
}
