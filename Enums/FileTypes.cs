

using System.ComponentModel;

/**
 * Author: Branden Brideau
 * Date: 3/6/2024
 * 
 * Purpose: File enum types.
 */

namespace PackageCreator.Enums
{
    /// <summary>
    /// Types of files that can be packaged.
    /// </summary>
    internal enum FileTypes
    {
        [Description("EXE")]
        EXE,
        [Description("MSI")]
        MSI,
        [Description("MSIX")]
        MSIX
    }

    /// <summary>
    /// Extention class  to get the description.
    /// </summary>
    internal static class FileType
    {
        internal static string Get(this FileTypes des)
        {
            DescriptionAttribute[]? attributes = (DescriptionAttribute[]?)des
           .GetType()?
           .GetField(des.ToString())?
           .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes?.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
