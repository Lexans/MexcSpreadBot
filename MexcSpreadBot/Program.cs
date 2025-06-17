namespace MexcSpreadBot
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.IO.Directory.CreateDirectory("data");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());

        }



        static List<Exception> lastExList = new List<Exception>();
        static DateTime lastExTime = DateTime.UtcNow;
        public static void WriteToLog(string userMsg, Exception ex)
        {
            //если новый день, то очищаем список прошлых ошибок
            if (lastExTime.Date != DateTime.UtcNow.Date)
                lastExList.Clear();

            lastExTime = DateTime.UtcNow;

            if (lastExList.FirstOrDefault((x) => ex.Message == x.Message && ex.Source == x.Source && ex.StackTrace == x.StackTrace) != null)
                return;

            DateTime dt = DateTime.UtcNow;
            string LogFile = "logs/log_" + dt.ToString("yyyyMMdd") + ".txt";
            System.IO.Directory.CreateDirectory("logs");

            string text = DateTime.UtcNow.ToString() +
                " " + userMsg +
               ". Message: " + ex.Message +
               " Source: " + ex.Source +
               " Inner: " + ((ex.InnerException != null) ? ex.InnerException.Message : "null") +
               ". StackTrace: " + ex.StackTrace;

            File.AppendAllText(LogFile, text + Environment.NewLine);

            lastExList.Add(ex);
        }
    }
}