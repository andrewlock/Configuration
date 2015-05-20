// <auto-generated />
namespace Microsoft.Framework.Configuration
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.Framework.Configuration.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Cannot create instance of type '{0}' because it is either abstract or an interface.
        /// </summary>
        internal static string Error_CannotActivateAbstractOrInterface
        {
            get { return GetString("Error_CannotActivateAbstractOrInterface"); }
        }

        /// <summary>
        /// Cannot create instance of type '{0}' because it is either abstract or an interface.
        /// </summary>
        internal static string FormatError_CannotActivateAbstractOrInterface(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_CannotActivateAbstractOrInterface"), p0);
        }

        /// <summary>
        /// Failed to convert '{0}' to type '{1}'.
        /// </summary>
        internal static string Error_FailedBinding
        {
            get { return GetString("Error_FailedBinding"); }
        }

        /// <summary>
        /// Failed to convert '{0}' to type '{1}'.
        /// </summary>
        internal static string FormatError_FailedBinding(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_FailedBinding"), p0, p1);
        }

        /// <summary>
        /// Failed to create instance of type '{0}'.
        /// </summary>
        internal static string Error_FailedToActivate
        {
            get { return GetString("Error_FailedToActivate"); }
        }

        /// <summary>
        /// Failed to create instance of type '{0}'.
        /// </summary>
        internal static string FormatError_FailedToActivate(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_FailedToActivate"), p0);
        }

        /// <summary>
        /// Unable to resolve path '{0}'; construct this {1} with a non-null {2}.
        /// </summary>
        internal static string Error_MissingBasePath
        {
            get { return GetString("Error_MissingBasePath"); }
        }

        /// <summary>
        /// Unable to resolve path '{0}'; construct this {1} with a non-null {2}.
        /// </summary>
        internal static string FormatError_MissingBasePath(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_MissingBasePath"), p0, p1, p2);
        }

        /// <summary>
        /// Cannot create instance of type '{0}' because it is missing a public parameterless constructor.
        /// </summary>
        internal static string Error_MissingParameterlessConstructor
        {
            get { return GetString("Error_MissingParameterlessConstructor"); }
        }

        /// <summary>
        /// Cannot create instance of type '{0}' because it is missing a public parameterless constructor.
        /// </summary>
        internal static string FormatError_MissingParameterlessConstructor(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_MissingParameterlessConstructor"), p0);
        }

        /// <summary>
        /// A configuration source is not registered. Please register one before setting a value.
        /// </summary>
        internal static string Error_NoSources
        {
            get { return GetString("Error_NoSources"); }
        }

        /// <summary>
        /// A configuration source is not registered. Please register one before setting a value.
        /// </summary>
        internal static string FormatError_NoSources()
        {
            return GetString("Error_NoSources");
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