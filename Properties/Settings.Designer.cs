﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnglishGuidance.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ОЛЕГ-ПК\\SQLEXPRESS;Initial Catalog=EngGuid_db;Integrated Security=Tru" +
            "e")]
        public string EngGuid_dbConnectionString {
            get {
                return ((string)(this["EngGuid_dbConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ОЛЕГ-ПК\\SQLEXPRESS;Initial Catalog=Eng_Guid;Integrated Security=True")]
        public string Eng_GuidConnectionString {
            get {
                return ((string)(this["Eng_GuidConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Eng_Guid.mdf;" +
            "Integrated Security=True")]
        public string Eng_GuidConnectionString1 {
            get {
                return ((string)(this["Eng_GuidConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ОЛЕГ-ПК\\SQLEXPRESS;Initial Catalog=C:\\USERS\\ОЛЕГ\\SOURCE\\REPOS\\ENGLISH" +
            "GUIDANCE\\ENGLISHGUIDANCE\\ENG_GUID.MDF;Integrated Security=True")]
        public string C__USERS_ОЛЕГ_SOURCE_REPOS_ENGLISHGUIDANCE_ENGLISHGUIDANCE_ENG_GUID_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_ОЛЕГ_SOURCE_REPOS_ENGLISHGUIDANCE_ENGLISHGUIDANCE_ENG_GUID_MDFConnection" +
                    "String"]));
            }
        }

        public string English_Guidance_dbConnectionString { get; internal set; }
    }
}
