using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace GestorProductos.Repository
{
    public class RepositoryJson<T> : IRepository<T> where T : IEntidad
    {
        private readonly string _ruta;
        private List<T> _items;
        private int _proximoId;

        public RepositoryJson(string ruta)
        {
            _ruta = ruta;
            if (File.Exists(_ruta))
            {
                string json = File.ReadAllText(_ruta);
                _items = JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
            }
            else
            {
                _items = new List<T>();
            }
            _proximoId = _items.Count == 0 ? 1 : _items.Max(x => x.Id) + 1;
        }

        public void Agregar(T entidad)
        {
            entidad.Id = _proximoId++;
            _items.Add(entidad);
            Guardar();
        }
        public List<T> ObtenerTodos()
        {
            return _items.ToList();
        }
        public void Eliminar(int id)
        {
            _items.RemoveAll(x => x.Id == id);
            Guardar();
        }
        public void Modificar(T entidad)
        {
            int indice = _items.FindIndex(x => x.Id == entidad.Id);
            if (indice == -1) return;

            _items[indice] = entidad;
            Guardar();
        }
        private void Guardar()
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(_items, opciones);
            File.WriteAllText(_ruta, json);
        }
    }
}
