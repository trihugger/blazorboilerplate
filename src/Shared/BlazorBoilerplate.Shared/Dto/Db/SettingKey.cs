namespace BlazorBoilerplate.Shared.Dto.Db
{
    public enum SettingKey
    {
        MainConfiguration_Runtime,
        MainConfiguration_Theme,

        ThemeConfiguration_PrimaryColor,
        ThemeConfiguration_SecondaryColor,
        ThemeConfiguration_OnPrimaryColor,
        ThemeConfiguration_OnSecondaryColor,
        ThemeConfiguration_Background,

        ThemeConfiguration_headerlogo,
        ThemeConfiguration_smalllogo,

        EmailConfiguration_SmtpServer,
        EmailConfiguration_SmtpPort,
        EmailConfiguration_SmtpUsername,
        EmailConfiguration_SmtpPassword,
        EmailConfiguration_SmtpUseSSL,

        EmailConfiguration_FromName,
        EmailConfiguration_FromAddress,
        EmailConfiguration_ReplyToAddress,

        EmailConfiguration_PopServer,
        EmailConfiguration_PopPort,
        EmailConfiguration_PopUsername,
        EmailConfiguration_PopPassword,
        EmailConfiguration_PopUseSSL,

        EmailConfiguration_ImapServer,
        EmailConfiguration_ImapPort,
        EmailConfiguration_ImapUsername,
        EmailConfiguration_ImapPassword,
        EmailConfiguration_ImapUseSSL,
    }
}
