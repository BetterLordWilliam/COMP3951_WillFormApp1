namespace WillFormApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        /// <summary>
        /// Epic program
        /// </summary>
        static void Crazy()
        {
            
        }

        /// <summary>
        /// HTML docstring is crazy
        /// </summary>
        /// <param name="n"></param>
        /// <param name="test"></param>
        static void CrazyTwo(int n, Boolean test)
        {

        }
    }
}