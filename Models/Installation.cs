/**
 * Author: Branden Brideau
 * Date: 3/6/2024
 * 
 * Purpose: Model for installation information.
 */

namespace PackageCreator.Models
{
    /// <summary>
    /// Installation Model.
    /// </summary>
    internal class Installation
    {
        /// <summary>
        /// Installation command.
        /// </summary>
        internal required string InstallCommand { get; set; }

        /// <summary>
        /// Uninstall command.
        /// </summary>
        internal required string UninstallCommand { get; set; }

        /// <summary>
        /// Detection script used in Intune.
        /// </summary>
        internal required string DetectionScript { get; set; }
    }
}
