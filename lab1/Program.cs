using GalaxyLogic;

namespace lab1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

                string fileName = args.Length > 0 ? args[0] : "galaxy_output.bmp";
                Console.WriteLine($"Генерация галактики в {fileName}...");

                var engine = new GalaxyEngine();
                Bitmap bmp = new Bitmap(500, 500);
                bmp.Save(fileName);
                Console.WriteLine("Готово!");
            
        }
    }
}