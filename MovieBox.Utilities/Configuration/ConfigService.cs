#region Includes

// .NET Libraries
using System.Configuration;

#endregion

namespace Utilities.Configuration
{
    /// <summary>
    /// Represents a configuration service provider in the system.
    /// </summary>
    public class ConfigService
    {
        #region Fields

        private TypeEnvironment _AppModeType;
        private string _ApplicationName;
        private string _ConnectionString;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the application mode environment.
        /// </summary>
        public TypeEnvironment AppModeType
        {
            get
            {
                _AppModeType = TypeEnvironment.None;

                string appMode = GetConfigSetting("AppMode");

                if (!string.IsNullOrEmpty(appMode))
                {
                    switch (appMode)
                    {
                        case "test":
                        case "tst":
                            _AppModeType = TypeEnvironment.TST;
                            break;
                        case "production":
                        case "prd":
                        case "prod":
                            _AppModeType = TypeEnvironment.PRD;
                            break;
                        case "qat":
                        case "qa":
                        case "sandbox":
                            _AppModeType = TypeEnvironment.QAT;
                            break;
                        default:
                            _AppModeType = TypeEnvironment.DEV;
                            break;
                    }
                }
                else
                    _AppModeType = TypeEnvironment.DEV;

                return _AppModeType;
            }
            set { _AppModeType = value; }
        }

        /// <summary>
        /// Gets or sets the application name.
        /// </summary>
        public string ApplicationName
        {
            get => GetConfigSetting("AppName");
            set => _ApplicationName = value;
        }

        /// <summary>
        /// Gets or sets the default connection string.
        /// </summary>
        public string ConnectionString
        {
            get => GetConnectionString("xlconnection");
            set => _ConnectionString = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the ConfigService in the system.
        /// </summary>
        public ConfigService()
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the configuration setting for the specified setting from the .config file.
        /// </summary>
        /// <param name="setting">The app setting name to retrieve.</param>
        /// <returns>The value from the configuration setting.</returns>
        public string GetConfigSetting(string setting)
        {
            return ConfigurationManager.AppSettings[setting] == null ? string.Empty : ConfigurationManager.AppSettings[setting].ToString();
        }

        /// <summary>
        /// Returns the connection string for a particular setting.
        /// </summary>
        /// <param name="setting">The connection string setting to return.</param>
        /// <returns>The value from the connection string setting.</returns>
        public string GetConnectionString(string setting)
        {
            return ConfigurationManager.ConnectionStrings[setting].ConnectionString;
        }

        #endregion
    }
}
