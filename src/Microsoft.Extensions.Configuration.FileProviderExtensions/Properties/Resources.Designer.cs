// <auto-generated />
namespace Microsoft.Extensions.Configuration.FileProviderExtensions
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.Extensions.Configuration.FileProviderExtensions.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The configuration file '{0}' was not found and is not optional.
        /// </summary>
        internal static string Error_FileNotFound
        {
            get { return GetString("Error_FileNotFound"); }
        }

        /// <summary>
        /// The configuration file '{0}' was not found and is not optional.
        /// </summary>
        internal static string FormatError_FileNotFound(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_FileNotFound"), p0);
        }

        /// <summary>
        /// File path must be a non-empty string.
        /// </summary>
        internal static string Error_InvalidFilePath
        {
            get { return GetString("Error_InvalidFilePath"); }
        }

        /// <summary>
        /// File path must be a non-empty string.
        /// </summary>
        internal static string FormatError_InvalidFilePath()
        {
            return GetString("Error_InvalidFilePath");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}