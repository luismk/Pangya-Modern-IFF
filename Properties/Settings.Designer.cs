﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Configuration;
using System.Diagnostics;

namespace Pangya_Modern_Editor.Properties
{


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }

        private static void AutoSaveSettings(object sender, EventArgs e)
        {
            if (Default != null)
            {
                Default.Save();
            }
        }


        [UserScopedSetting, DefaultSettingValue("")]
        public string ArquivoIff
        {
            get =>
                Convert.ToString(this["ArquivoIff"]);
            set =>
                this["ArquivoIff"] = value;
        }

        [UserScopedSetting, DefaultSettingValue("")]
        public string DiretorioIff
        {
            get =>
                Convert.ToString(this["DiretorioIff"]);
            set =>
                this["DiretorioIff"] = value;
        }

        [DefaultSettingValue(""), UserScopedSetting]
        public string iffFavorito
        {
            get =>
                Convert.ToString(this["iffFavorito"]);
            set =>
                this["iffFavorito"] = value;
        }

        [UserScopedSetting, DefaultSettingValue("")]
        public string login
        {
            get =>
                Convert.ToString(this["login"]);
            set =>
                this["login"] = value;
        }

        [DefaultSettingValue(""), UserScopedSetting]
        public string DiretorioDividir
        {
            get =>
                Convert.ToString(this["DiretorioDividir"]);
            set =>
                this["DiretorioDividir"] = value;
        }

        [DefaultSettingValue("True"), UserScopedSetting]
        public bool BuscarImagensBanco
        {
            get =>
                Convert.ToBoolean(this["BuscarImagensBanco"]);
            set =>
                this["BuscarImagensBanco"] = value;
        }

        [UserScopedSetting, DefaultSettingValue("False")]
        public bool TrabalharOffline
        {
            get =>
                Convert.ToBoolean(this["TrabalharOffline"]);
            set =>
                this["TrabalharOffline"] = value;
        }

        [UserScopedSetting, DefaultSettingValue("False")]
        public bool ImagensWeb
        {
            get =>
                Convert.ToBoolean(this["ImagensWeb"]);
            set =>
                this["ImagensWeb"] = value;
        }
    }
}
