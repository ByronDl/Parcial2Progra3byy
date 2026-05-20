using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Parcial2Progra3by
{
    public class ArchivoAlbumes
    {
        string ruta = "albumes.json";

        public void Guardar(List<Album> lista)
        {
            string json = JsonConvert.SerializeObject(
                lista,
                Newtonsoft.Json.Formatting.Indented
            );

            File.WriteAllText(ruta, json);
        }

        public List<Album> Leer()
        {
            if (!File.Exists(ruta))
            {
                return new List<Album>();
            }

            string json = File.ReadAllText(ruta);

            return JsonConvert.DeserializeObject<List<Album>>(json)
                   ?? new List<Album>();
        }
    }
}
