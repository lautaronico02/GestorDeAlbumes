using GestorProductos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorProductos
{
    public class AlbumController
    {
        private readonly IRepository<Album> _repo;

        public AlbumController(IRepository<Album> repo)
        {
            _repo = repo;
        }

        public void Agregar(string titulo, string artista, decimal precio, int stock)
        {
            var album = new Album
            {
                Titulo = titulo,
                Artista = artista,
                Precio = precio,
                Stock = stock
            };
            _repo.Agregar(album); // el Id lo pone el repo
        }

        public List<Album> ObtenerTodos() => _repo.ObtenerTodos();

        public void Eliminar(int id) => _repo.Eliminar(id);

        public void Modificar(Album modificado) => _repo.Modificar(modificado);

        public List<Album> Buscar(string texto)
        {
            var todos = _repo.ObtenerTodos();
            if (string.IsNullOrWhiteSpace(texto)) return todos;

            return todos
                .Where(a => a.Titulo.ToLower().Contains(texto.ToLower())
                         || a.Artista.ToLower().Contains(texto.ToLower()))
                .ToList();
        }
    }
}
