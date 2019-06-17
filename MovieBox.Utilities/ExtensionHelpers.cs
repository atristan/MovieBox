#region Includes

// Microsoft Libraries
using Microsoft.Win32;

#endregion

namespace Utilities
{
    /// <summary>
    /// Methods to facilitate working with file extensions.
    /// </summary>
    public static class ExtensionHelpers
    {
        /// <summary>
        /// Gets the default extension mapped in the Windows OS.
        /// </summary>
        /// <param name="mimeType">The mime type as a string.</param>
        /// <returns>Default extension for the mime type as a string.</returns>
        public static string GetDefaultExt(string mimeType)
        {
            string result = string.Empty;
            RegistryKey key;
            object value;

            key = Registry.ClassesRoot.OpenSubKey($@"MIME\Database\Content Type\{mimeType}", false);
            value = key?.GetValue("Extension", null);
            result = value?.ToString() ?? string.Empty;

            return result;
        }
    }
}
