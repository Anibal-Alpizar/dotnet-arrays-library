using dotnet_arrays_library.Layers.UI.Maintenances;

namespace dotnet_arrays_library
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmMaintenanceCategoryMovie frmMaintenanceCategoryMovie = new frmMaintenanceCategoryMovie();

            Application.Run(new frmMaintenanceCategoryMovie());
        }
    }
}