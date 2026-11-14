using GestorProductos.Repository;

namespace GestorProductos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var repo = new RepositoryJson<Album>("albumes.json");
            var controller = new AlbumController(repo);
            var form = new FormPrincipal(controller);

            Application.Run(form);
        }
    }
}