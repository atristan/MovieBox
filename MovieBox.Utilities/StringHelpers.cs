#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

#endregion

namespace Utilities
{
    /// <summary>
    /// Generic string helpers and functions to work with strings.
    /// </summary>
    public static class StringHelpers
    {
        /// <summary>
        /// Splits camel-case string into separate words.
        /// </summary>
        /// <param name="value">Camel-case string to split.</param>
        /// <returns>String array of input string split into separate words.</returns>
        public static string[] SplitCamelCase(this string value)
        {
            return Regex.Split(value, @"(?<!^)(?=[A-Z])");
        }

        /// <summary>
        /// Removes unwanted values from a string.
        /// </summary>
        /// <param name="items">A dictionary of strings to operate against.</param>
        /// <param name="values">A dictionary of values to look for and what to replace them with.</param>
        /// <returns>A dictionary of new values with characters removed.</returns>
        public static Dictionary<string, string> RemoveUnwantedValues(Dictionary<string, string> items, Dictionary<string, string> values)
        {
            string temp = string.Empty;
            Dictionary<string, string> results = new Dictionary<string, string>();

            // Loop through items to modify
            foreach (KeyValuePair<string, string> item in items)
            {
                // Assign current item value to temporary storage
                temp = item.Value;

                // Iterate through all characters to replace
                foreach (KeyValuePair<string, string> value in values)
                    temp = temp.Replace(value.Key, value.Value);

                // Add modified value to results
                results.Add(item.Key, temp);
            }

            return results;
        }

        /// <summary>
        /// Takes a string of digits and attempts to format the string into a phone number in the following format:
        /// +x (xxx) xxx-xxxx
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <param name="code">The country code; default is US.</param>
        /// <returns>Formatted string value in the format +x (xxx) xxx-xxxx.</returns>
        public static string FormatPhoneNumber(string value, int code = 1)
        {
            int countrycode = code;

            // Remove "+" if it exists
            value = value.Substring(value.IndexOf("+", StringComparison.Ordinal) + 1);

            // Get rid of country code.
            if (value.Length > 10)
            {
                switch (code)
                {
                    // Mexico
                    case 52:
                        value = value.Substring(2);
                        break;

                    // US
                    default:
                        value = value.Substring(1);
                        break;
                }
            }

            // Format phone number
            return $"+{countrycode.ToString()} ({value.Substring(0, 3)}) {value.Substring(3, 3)}-{value.Substring(6)}";
        }

        /// <summary>
        /// Gets the name of the type.
        /// </summary>
        /// <typeparam name="T">The type to get the name for.</typeparam>
        /// <returns>The type name as a string.</returns>
        public static string GetTypeName<T>()
        {
            string result = string.Empty;
            Type type = typeof(T);
            if (type.IsGenericType)
                result = type.Name;
            return result;
        }

        /// <summary>
        /// Builds a complete path including file name and extension.
        /// </summary>
        /// <param name="path">The root path.</param>
        /// <param name="fileName">The file name.</param>
        /// <param name="ext">The file extension.</param>
        /// <param name="useTimestamp">Flag to use a timestamp or not.</param>
        /// <returns>A string representing the complete file path and filename with extension.</returns>
        public static string GenerateFileName(string path, string fileName, string ext, bool useTimestamp = false)
        {
            string result = string.Empty;
            ext = !(ext.Contains(".")) ? $".{ext}" : ext;

            if (!string.IsNullOrEmpty(path) && !string.IsNullOrEmpty(fileName) && !string.IsNullOrEmpty(ext))
            {
                if (useTimestamp)
                {
                    string timestamp =
                        $"{DateTime.Now.ToShortDateString().Replace("/", "-")}-{DateTime.Now.ToShortTimeString()}".Replace(":", "");
                    result = $@"{path}\{timestamp}_{fileName}{ext}";
                }
                else
                    result = $@"{path}\{fileName}{ext}";
            }

            return result;
        }

        /// <summary>
        /// Builds the paramter string for an api endpoint.
        /// </summary>
        /// <param name="queryparams">Dictionary containing the keys and values for the parameters to add.</param>
        /// <returns>A query string for the api endpoint.</returns>
        public static string ParameterBuilder(Dictionary<string, string> queryparams)
        {
            // Get last item in the dictionary
            var last = queryparams.Values.Last();

            string result = string.Empty;
            StringBuilder sb = new StringBuilder();

            // Add beginning of parameter string
            sb.Append("?");

            // Iterate over items in dictionary
            foreach (KeyValuePair<string, string> param in queryparams)
            {
                if (!param.Key.ToLower().Contains("account"))
                {
                    if (!string.IsNullOrEmpty(param.Value))
                        // Add parameter
                        sb.Append($"{param.Key}={param.Value}");

                    // Check if item is not the last item
                    if (param.Value != last && !string.IsNullOrEmpty(param.Value))
                        sb.Append("&");
                }
            }

            // Assign results from string builder
            result = sb.ToString();

            // Clear out sb
            sb.Remove(0, sb.Length);

            return result;
        }
}
}
