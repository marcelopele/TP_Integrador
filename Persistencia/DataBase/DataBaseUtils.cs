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
        String archivoCsv = @".\Datos\";

        // Método para buscar un registro con un valor específico
        public List<String> BuscarRegistrosPorValor(String nombreArchivo, int col_id, String valor_id)
        {
            List<String> salida = new List<String>();
            String rutaArchivo = Path.Combine(Directory.GetCurrentDirectory(), "Datos", nombreArchivo);
            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    while (!sr.EndOfStream)
                    {
                        String[] datos = sr.ReadLine().ToString().Split(';');
                        if (datos[col_id] == valor_id)
                        {
                            salida.Add(String.Join(";", datos));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo:");
                Console.WriteLine(e.Message);
            }
            return salida;
        }

        // Método para buscar un valor en una columna específica
        public String BuscarValor(String nombreArchivo, int col_id, String valor_id, int col_valor_buscado)
        {
            String salida = null;
            String rutaArchivo = Path.Combine(Directory.GetCurrentDirectory(), "Datos", nombreArchivo);
            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    while (!sr.EndOfStream)
                    {
                        String[] datos = sr.ReadLine().ToString().Split(';');
                        if (datos[col_id] == valor_id)
                        {
                            salida = datos[col_valor_buscado];
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo:");
                Console.WriteLine(e.Message);
            }
            return salida;
        }

        // Método para agregar un registro
        public void AgregarRegistro(String nombreArchivo, String nuevoRegistro)
        {
            String rutaArchivo = Path.Combine(Directory.GetCurrentDirectory(), "Datos", nombreArchivo);

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(rutaArchivo))
                {
                    Console.WriteLine("El archivo no existe: " + rutaArchivo);
                    return;
                }

                // Abrir el archivo y agregar el nuevo registro
                using (StreamWriter sw = new StreamWriter(rutaArchivo, append: true))
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
            String rutaArchivo = Path.Combine(Directory.GetCurrentDirectory(), "Datos", nombreArchivo);

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(rutaArchivo))
                {
                    Console.WriteLine("El archivo no existe: " + rutaArchivo);
                    return;
                }

                // Leeo el archivo y lo guardo en una lista con el registro modificado
                List<String> listaModificada = new List<String>();
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    while (!sr.EndOfStream)
                    {
                        String[] datos = sr.ReadLine().ToString().Split(';');
                        if (datos[col_id] == valor_id)
                        {
                            listaModificada.Add(nuevoRegistro);
                        }
                        else
                        {
                            listaModificada.Add(String.Join(";", datos));
                        }
                    }
                    sr.Close();
                }

                // Escribo el archivo con el registro modificado
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    foreach (String item in listaModificada)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo:");
                Console.WriteLine(e.Message);
            }
        }

        // Elimina uno o varios registros buscando un valor en una columna
        public void EliminarRegistros(String nombreArchivo, int col_id, String valor_id)
        {
            String rutaArchivo = Path.Combine(Directory.GetCurrentDirectory(), "Datos", nombreArchivo);

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(rutaArchivo))
                {
                    Console.WriteLine("El archivo no existe: " + rutaArchivo);
                    return;
                }

                // Leeo el archivo y lo guardo en una lista sin los registros a eliminar
                List<String> listaModificada = new List<String>();
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    while (!sr.EndOfStream)
                    {
                        String[] datos = sr.ReadLine().ToString().Split(';');
                        if (datos[col_id] != valor_id)
                        {
                            listaModificada.Add(String.Join(";", datos));
                        }
                    }
                    sr.Close();
                }

                // Escribo el archivo con el registro modificado
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    foreach (String item in listaModificada)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo:");
                Console.WriteLine(e.Message);
            }
        }

        public void EliminarRegistrosBKP(String nombreArchivo, int col_id, String valor_id)
        {
            String rutaArchivo = Path.Combine(Directory.GetCurrentDirectory(), "Datos", nombreArchivo);

            FileInfo fi = new FileInfo(rutaArchivo);
            if (!fi.Exists)
            {
                Console.WriteLine("El archivo no existe: " + nombreArchivo);
                return;
            }
            else
            {
                StreamReader sr = fi.OpenText();

                // Leo el archivo y lo guardo en una lista sin el/los registros que coincidan
                List<String> listado = new List<String>();
                while (!sr.EndOfStream)
                {
                    String[] datos = sr.ReadLine().ToString().Split(';');
                    if (datos[col_id] != valor_id)
                    {
                        listado.Add(String.Join(";", datos));
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
