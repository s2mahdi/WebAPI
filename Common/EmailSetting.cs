namespace Common
{
    public class EmailSetting
    {
        public string From { get; set; }
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public bool EnableSsl { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Subject { get; set; }
    }
    
    public class SmsSetting
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FromNumber { get; set; }
    }
}