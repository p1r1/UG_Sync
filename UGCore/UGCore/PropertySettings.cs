using System.Configuration;

namespace UGCore {
    public class PropertySettings {
        public void saveSettings() {
            // Add extra settings when application starts up.

            System.Configuration.SettingsProperty property = new System.Configuration.SettingsProperty("CustomSetting");
            property.DefaultValue = "Default";
            property.IsReadOnly = false;
            property.PropertyType = typeof(string);
            property.Provider = Properties.Settings.Default.Providers["LocalFileSettingsProvider"];
            property.Attributes.Add(typeof(System.Configuration.UserScopedSettingAttribute), new System.Configuration.UserScopedSettingAttribute());
            Properties.Settings.Default.Properties.Add(property);

            // Load settings now.

            Properties.Settings.Default.Reload();
        }

        public void saveSetting(string settingName, string settingValue, System.Type type) {
            //----------< save_Settings() >----------
            SettingsProperty prop = null;

            if (Properties.Settings.Default.Properties[settingName] != null) {
                //< existing Setting >
                prop = Properties.Settings.Default.Properties[settingName];

            }

            else {
                prop = new System.Configuration.SettingsProperty(settingName);
                prop.PropertyType = type;
                Properties.Settings.Default.Properties.Add(prop);
                Properties.Settings.Default.Save();
                //</ new Setting >

            }

            Properties.Settings.Default.Properties[settingName].DefaultValue = settingValue;
            Properties.Settings.Default.Save();

        }



        public string readSetting(string settingName) {
            string sResult = "";
            //< get Setting >
            if (Properties.Settings.Default.Properties[settingName] != null) {
                sResult = Properties.Settings.Default.Properties[settingName].DefaultValue.ToString();
            }

            if (sResult == "NaN")
                sResult = "0";

            return sResult;
        }
    }
}
