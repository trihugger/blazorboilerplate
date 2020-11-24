using BlazorBoilerplate.Constants;
using System;
using System.Collections.Generic;

namespace BlazorBoilerplate.Shared.Dto.Db
{
    public enum BlazorRuntime
    {
        Server,
        WebAssembly
    }
    public static class TenantSettingValues
    {
        public static readonly Dictionary<SettingKey, Tuple<string, SettingType>> Default =
                new Dictionary<SettingKey, Tuple<string, SettingType>>()
                {
                    { SettingKey.MainConfiguration_Runtime,         new Tuple<string, SettingType>(BlazorRuntime.Server.ToString(), SettingType.String) },

                    { SettingKey.EmailConfiguration_SmtpServer,     new Tuple<string, SettingType>("smtp.gmail.com", SettingType.String) },
                    { SettingKey.EmailConfiguration_SmtpPort,       new Tuple<string, SettingType>("465", SettingType.Int) },
                    { SettingKey.EmailConfiguration_SmtpUsername,   new Tuple<string, SettingType>("email@domain.com", SettingType.String) },
                    { SettingKey.EmailConfiguration_SmtpPassword,   new Tuple<string, SettingType>("PASSWORD", SettingType.String) },
                    { SettingKey.EmailConfiguration_SmtpUseSSL,     new Tuple<string, SettingType>("true", SettingType.Boolean) },
                    { SettingKey.EmailConfiguration_FromName,       new Tuple<string, SettingType>("Coastal Hub Team", SettingType.String) },
                    { SettingKey.EmailConfiguration_FromAddress,    new Tuple<string, SettingType>("email@coastaloutsourcedsolutions.com", SettingType.String) },
                    { SettingKey.EmailConfiguration_ReplyToAddress, new Tuple<string, SettingType>("email@coastaloutsourcedsolutions.com", SettingType.String) },
                    { SettingKey.EmailConfiguration_PopServer,      new Tuple<string, SettingType>("pop.gmail.com", SettingType.String) },
                    { SettingKey.EmailConfiguration_PopPort,        new Tuple<string, SettingType>("995", SettingType.Int) },
                    { SettingKey.EmailConfiguration_PopUsername,    new Tuple<string, SettingType>("email@coastaloutsourcedsolutions.com", SettingType.String) },
                    { SettingKey.EmailConfiguration_PopPassword,    new Tuple<string, SettingType>("PASSWORD", SettingType.String) },
                    { SettingKey.EmailConfiguration_PopUseSSL,      new Tuple<string, SettingType>("true", SettingType.Boolean) },
                    { SettingKey.EmailConfiguration_ImapServer,     new Tuple<string, SettingType>("imap.gmail.com", SettingType.String) },
                    { SettingKey.EmailConfiguration_ImapPort,       new Tuple<string, SettingType>("993", SettingType.Int) },
                    { SettingKey.EmailConfiguration_ImapUsername,   new Tuple<string, SettingType>("email@coastaloutsourcedsolutions.com", SettingType.String) },
                    { SettingKey.EmailConfiguration_ImapPassword,   new Tuple<string, SettingType>("PASSWORD", SettingType.String) },
                    { SettingKey.EmailConfiguration_ImapUseSSL,     new Tuple<string, SettingType>("true", SettingType.Boolean) },

                    { SettingKey.ThemeConfiguration_PrimaryColor,       new Tuple<string, SettingType>("#1A237E", SettingType.String) },
                    { SettingKey.ThemeConfiguration_SecondaryColor,     new Tuple<string, SettingType>("#1976D3", SettingType.String) },
                    { SettingKey.ThemeConfiguration_OnPrimaryColor,     new Tuple<string, SettingType>("#ffffff", SettingType.String) },
                    { SettingKey.ThemeConfiguration_OnSecondaryColor,   new Tuple<string, SettingType>("#333", SettingType.String) },
                    { SettingKey.ThemeConfiguration_TextPrimaryColor,   new Tuple<string, SettingType>("#001037", SettingType.String) },
                    { SettingKey.ThemeConfiguration_TextSecondaryColor,   new Tuple<string, SettingType>("#c48003", SettingType.String) },
                    { SettingKey.ThemeConfiguration_Background,   new Tuple<string, SettingType>("#1A237E", SettingType.String) },
                    { SettingKey.ThemeConfiguration_Surface,   new Tuple<string, SettingType>("#BBDEFA", SettingType.String) },
                    { SettingKey.ThemeConfiguration_OnSurface,   new Tuple<string, SettingType>("#ffffff", SettingType.String) },
                    { SettingKey.ThemeConfiguration_NavPrimaryColor,   new Tuple<string, SettingType>("#1A237E", SettingType.String) },
                    { SettingKey.ThemeConfiguration_NavSecondaryColor,   new Tuple<string, SettingType>("#2196F3", SettingType.String) },
                    { SettingKey.ThemeConfiguration_NavPaintType,   new Tuple<string, SettingType>("Gradient", SettingType.String) }, //Simple, Gradient
                    { SettingKey.ThemeConfiguration_NavOrientation,   new Tuple<string, SettingType>("180", SettingType.Int) },
                    { SettingKey.ThemeConfiguration_NavSplit,   new Tuple<string, SettingType>("160", SettingType.Int) },
                };
    }
}
