﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Notes.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color UserColor {
            get {
                return ((global::System.Drawing.Color)(this["UserColor"]));
            }
            set {
                this["UserColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Arial Rounded MT Bold, 15pt")]
        public global::System.Drawing.Font UserFont {
            get {
                return ((global::System.Drawing.Font)(this["UserFont"]));
            }
            set {
                this["UserFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 153, 0")]
        public global::System.Drawing.Color UserTheme {
            get {
                return ((global::System.Drawing.Color)(this["UserTheme"]));
            }
            set {
                this["UserTheme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OnContactsPane {
            get {
                return ((bool)(this["OnContactsPane"]));
            }
            set {
                this["OnContactsPane"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500, 500")]
        public global::System.Drawing.Size UserSize {
            get {
                return ((global::System.Drawing.Size)(this["UserSize"]));
            }
            set {
                this["UserSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool StartOnWindowsStartUp {
            get {
                return ((bool)(this["StartOnWindowsStartUp"]));
            }
            set {
                this["StartOnWindowsStartUp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ExitOnClose {
            get {
                return ((bool)(this["ExitOnClose"]));
            }
            set {
                this["ExitOnClose"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SaveNotesAutomatically {
            get {
                return ((bool)(this["SaveNotesAutomatically"]));
            }
            set {
                this["SaveNotesAutomatically"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SaveContactsAutomatically {
            get {
                return ((bool)(this["SaveContactsAutomatically"]));
            }
            set {
                this["SaveContactsAutomatically"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CheckForUpdatesOnStartUp {
            get {
                return ((bool)(this["CheckForUpdatesOnStartUp"]));
            }
            set {
                this["CheckForUpdatesOnStartUp"] = value;
            }
        }
    }
}
