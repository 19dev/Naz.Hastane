﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Naz.Hastane.Medula.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://medula.sgk.gov.tr:80/medulaws/services/RaporIslemleri")]
        public string Naz_Medula_RaporIslemleri_RaporIslemleriService {
            get {
                return ((string)(this["Naz_Medula_RaporIslemleri_RaporIslemleriService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://medula.sgk.gov.tr:80/medulaws/services/YardimciIslemler")]
        public string Naz_Medula_YardimciIslemler_YardimciIslemlerService {
            get {
                return ((string)(this["Naz_Medula_YardimciIslemler_YardimciIslemlerService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://medula.sgk.gov.tr:80/medulaws/services/TakipFormuIslemleri")]
        public string Naz_Medula_TakipFormuIslemleri_TakipFormuIslemleriService {
            get {
                return ((string)(this["Naz_Medula_TakipFormuIslemleri_TakipFormuIslemleriService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://medula.sgk.gov.tr:80/medulaws/services/FaturaKayitIslemleri")]
        public string Naz_Medula_FaturaKayitIslemleri_FaturaKayitIslemleriService {
            get {
                return ((string)(this["Naz_Medula_FaturaKayitIslemleri_FaturaKayitIslemleriService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://medula.sgk.gov.tr:80/medulaws/services/HastaKabulIslemleri")]
        public string Naz_Medula_HastaKabulIslemleri_HastaKabulIslemleriService {
            get {
                return ((string)(this["Naz_Medula_HastaKabulIslemleri_HastaKabulIslemleriService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://medula.sgk.gov.tr:80/medulaws/services/HizmetKayitIslemleri")]
        public string Naz_Medula_HizmetKayitIslemleri_HizmetKayitIslemleriService {
            get {
                return ((string)(this["Naz_Medula_HizmetKayitIslemleri_HizmetKayitIslemleriService"]));
            }
        }
    }
}