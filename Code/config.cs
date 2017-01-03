using System;
using System.Configuration;
using System.Web;
namespace ConfigOperator
{
    public class ConfigurationOperator
    {
        private Configuration config;
        private string configPath;
        //private ConfigType configType;
        /// <summary>
        /// 对应的配置文件
        /// </summary>
        public Configuration Configuration
        {
            get { return config; }
            set { config = value; }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="configType">.config文件的类型，只能是网站配置文件或者应用程序配置文件</param>
        public ConfigurationOperator()
        {
            configPath = HttpContext.Current.Request.ApplicationPath;
            config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(configPath);
        }
        /// <summary>
        /// 添加应用程序配置节点，如果已经存在此节点，则会修改该节点的值
        /// </summary>
        /// <param name="key">节点名称</param>
        /// <param name="value">节点值</param>
        public void AddAppSetting(string key, string value)
        {
            AppSettingsSection appSetting = (AppSettingsSection)config.GetSection("appSettings");
            if (appSetting.Settings[key] == null)//如果不存在此节点，则添加
            {
                appSetting.Settings.Add(key, value);
            }
            else//如果存在此节点，则修改
            {
                ModifyAppSetting(key, value);
            }
        }
        /// <summary>
        /// 添加数据库连接字符串节点，如果已经存在此节点，则会修改该节点的值
        /// </summary>
        /// <param name="key">节点名称</param>
        /// <param name="value">节点值</param>
        public void AddConnectionString(string key, string connectionString)
        {
            ConnectionStringsSection connectionSetting = (ConnectionStringsSection)config.GetSection("connectionStrings");
            if (connectionSetting.ConnectionStrings[key] == null)//如果不存在此节点，则添加
            {
                ConnectionStringSettings connectionStringSettings = new ConnectionStringSettings(key, connectionString);
                connectionSetting.ConnectionStrings.Add(connectionStringSettings);
            }
            else//如果存在此节点，则修改
            {
                ModifyConnectionString(key, connectionString);
            }
        }
        /// <summary>
        /// 修改应用程序配置节点，如果不存在此节点，则会添加此节点及对应的值
        /// </summary>
        /// <param name="key">节点名称</param>
        /// <param name="value">节点值</param>
        public void ModifyAppSetting(string key, string newValue)
        {
            AppSettingsSection appSetting = (AppSettingsSection)config.GetSection("appSettings");
            if (appSetting.Settings[key] != null)//如果存在此节点，则修改
            {
                appSetting.Settings[key].Value = newValue;
            }
            else//如果不存在此节点，则添加
            {
                AddAppSetting(key, newValue);
            }
        }
        /// <summary>
        /// 修改数据库连接字符串节点，如果不存在此节点，则会添加此节点及对应的值
        /// </summary>
        /// <param name="key">节点名称</param>
        /// <param name="value">节点值</param>
        public void ModifyConnectionString(string key, string connectionString)
        {
            ConnectionStringsSection connectionSetting = (ConnectionStringsSection)config.GetSection("connectionStrings");
            if (connectionSetting.ConnectionStrings[key] != null)//如果存在此节点，则修改
            {
                connectionSetting.ConnectionStrings[key].ConnectionString = connectionString;
            }
            else//如果不存在此节点，则添加
            {
                AddConnectionString(key, connectionString);
            }
        }
        /// <summary>
        /// 保存所作的修改
        /// </summary>
        public void Save()
        {
            config.Save();
        }
    }
}