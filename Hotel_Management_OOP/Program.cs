namespace Hotel_Management_OOP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // db create
            using (var context = new UserDataContext())
            {
                context.Database.EnsureCreated();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
            //Application.Run(new SplashScreen());
            //Application.Run(new GuestTab());
            //Application.Run(new NEW_USER());
            //Application.Run(new BOOKING());
            //Application.Run(new HOME_DRAFT());

        }
    }
}