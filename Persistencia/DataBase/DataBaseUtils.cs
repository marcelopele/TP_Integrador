using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Persistencia.DataBase
{
    public class DataBaseUtils
    {
        string archivoCsv = @".\Datos\";

        //Método para buscar un registro
        public List<String> BuscarRegistro(String nombreArchivo)
        {
            archivoCsv = archivoCsv + nombreArchivo; // Cambia esta ruta al archivo CSV que deseas leer

            String rutaArchivo = Path.GetFullPath(archivoCsv); // Normaliza la ruta

            List<String> listado = new List<String>();

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        listado.Add(linea);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo:");
                Console.WriteLine(e.Message);
            }
            return listado;
        }

        // Método para borrar un registro
        public void BorrarRegistro(String id, String nombreArchivo)
        {
            archivoCsv = archivoCsv + nombreArchivo; // Cambia esta ruta al archivo CSV que deseas leer

            String rutaArchivo = Path.GetFullPath(archivoCsv); // Normaliza la ruta

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(rutaArchivo))
                {
                    Console.WriteLine("El archivo no existe: " + archivoCsv);
                    return;
                }

                // Leer el archivo y obtener las líneas
                List<string> listado = BuscarRegistro(nombreArchivo);

                // Filtrar las líneas que no coinciden con el ID a borrar (comparar solo la primera columna)
                var registrosRestantes = listado.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != id; // Verifica solo el ID (primera columna)
                }).ToList();

                // Sobrescribir el archivo con las líneas restantes
                File.WriteAllLines(archivoCsv, registrosRestantes);

                Console.WriteLine($"Registro con ID {id} borrado correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al intentar borrar el registro:");
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Pila de errores: {e.StackTrace}");
            }
        }

        // Método para agregar un registro
        public void AgregarRegistro(String nombreArchivo, String nuevoRegistro)
        {
            string archivoCsv = Path.Combine(Directory.GetCurrentDirectory(), "Persistencia", "Datos", nombreArchivo);

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(archivoCsv))
                {
                    Console.WriteLine("El archivo no existe: " + archivoCsv);
                    return;
                }

                // Abrir el archivo y agregar el nuevo registro
                using (StreamWriter sw = new StreamWriter(archivoCsv, append: true))
                {
                    sw.WriteLine(nuevoRegistro); // Agregar la nueva línea
                }

                Console.WriteLine("Registro agregado correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al intentar agregar el registro:");
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Pila de errores: {e.StackTrace}");
            }
        }

        // Método para modificar un registro
        public void ModificarRegistro(String nombreArchivo, int col_id, String valor_id, String nuevoRegistro)
        {
            archivoCsv = archivoCsv + nombreArchivo; // Cambia esta ruta al archivo CSV que deseas leer

            String rutaArchivo = Path.GetFullPath(archivoCsv); // Normaliza la ruta

            FileInfo fi = new FileInfo(rutaArchivo);
            if (!fi.Exists)
            {
                Console.WriteLine("El archivo no existe: " + nombreArchivo);
                return;
            }
            else
            {
                StreamReader sr = fi.OpenText();

                // Leo el archivo y lo guardo en una lista con el registro modificado
                List<String> listado = new List<String>();
                while (!sr.EndOfStream)
                {
                    String[] datos = sr.ReadLine().ToString().Split(';');
                    if (datos[col_id] == valor_id)
                    {
                        listado.Add(nuevoRegistro);
                    }
                    else
                    {
                        listado.Add(string.Join(";", datos));
                    }
                }
                sr.Close();

                // Escribo el archivo con el registro modificado
                StreamWriter sw = fi.CreateText();
                foreach (String item in listado)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
            }

        }

    }
}
