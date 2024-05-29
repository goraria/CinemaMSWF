namespace Project {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Cinema());
        }

        public static string connectionString = "Data Source = MEIFANG; Initial Catalog = Cinema; Integrated Security = True";
        public static DateTime now = DateTime.Today;
        public static string dateString = now.ToString("yyyy-MM-dd");
        public static string Japtor = "Japtor";
    }
}