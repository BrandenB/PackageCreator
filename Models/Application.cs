/**
 * Author: Branden Brideau
 * Date: 3/6/2024
 * 
 * Purpose: Application model.
 */
using PackageCreator.Enums;

namespace PackageCreator.Models
{
    /// <summary>
    /// Application Model
    /// </summary>
    internal class Application
    {
        /// <summary>
        /// Name of the application.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Version of the application
        /// </summary>
        internal required string Version { get; set; }

        /// <summary>
        /// Location of the application.
        /// </summary>
        internal required string Location { get; set; }

        /// <summary>
        /// Installation string of the application.
        /// </summary>
        internal required string Installation { get; set; }

        /// <summary>
        /// Type of application installation file.
        /// </summary>
        internal required FileTypes Type { get; set; }

        /// <summary>
        /// Information for the provising process.
        /// </summary>
        internal required Installation Provision { get; set; }

    }
}
