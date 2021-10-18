using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CapasCxC.Interfaces.Factura
{
    class HttpClientGet
    {
        static async Task Main(string[] args)
        {
            var url = "http://192.168.0.21:5000/fel/afiliado";

            using (var http = new HttpClient())
            {
                var response = await http.GetStringAsync(url);
                var posts = JsonConvert.DeserializeObject<List<Afiliado>>(response);

                foreach(var post in posts){
                    Console.WriteLine($"NIT: {post.NIT}");
                    Console.WriteLine($"NOMBRE_JURIDICO: {post.NOMBRE_JURIDICO}");
                    Console.WriteLine($"PRIMER_NOMBRE: {post.PRIMER_NOMBRE}");
                    Console.WriteLine($"SEGUNDO_NOMBRE: {post.SEGUNDO_NOMBRE}");
                    Console.WriteLine($"PRIMER_APELLIDO: {post.PRIMER_APELLIDO}");
                    Console.WriteLine($"SEGUNDO_APELLIDO: {post.SEGUNDO_APELLIDO}");
                    Console.WriteLine($"DIRECCION: {post.DIRECCION}");
                    Console.WriteLine($"DPI: {post.DPI}");
                    Console.WriteLine($"EMISOR: {post.EMISOR}");
                    Console.WriteLine($"ACTIVO: {post.ACTIVO}");
                    Console.WriteLine($"CERTIFICADOR: {post.CERTIFICADOR}");
                }
            }
        }

        static async Task connect()
        {
            var url = "http://192.168.0.21:5000/fel/afiliado";

            using (var http = new HttpClient())
            {
                var response = await http.GetStringAsync(url);
                var posts = JsonConvert.DeserializeObject<List<Afiliado>>(response);

                foreach (var post in posts)
                {
                    Console.WriteLine($"NIT: {post.NIT}");
                    Console.WriteLine($"NOMBRE_JURIDICO: {post.NOMBRE_JURIDICO}");
                    Console.WriteLine($"PRIMER_NOMBRE: {post.PRIMER_NOMBRE}");
                    Console.WriteLine($"SEGUNDO_NOMBRE: {post.SEGUNDO_NOMBRE}");
                    Console.WriteLine($"PRIMER_APELLIDO: {post.PRIMER_APELLIDO}");
                    Console.WriteLine($"SEGUNDO_APELLIDO: {post.SEGUNDO_APELLIDO}");
                    Console.WriteLine($"DIRECCION: {post.DIRECCION}");
                    Console.WriteLine($"DPI: {post.DPI}");
                    Console.WriteLine($"EMISOR: {post.EMISOR}");
                    Console.WriteLine($"ACTIVO: {post.ACTIVO}");
                    Console.WriteLine($"CERTIFICADOR: {post.CERTIFICADOR}");
                }
            }
        }



    }
}
