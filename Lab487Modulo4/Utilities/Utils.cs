using System;

namespace Lab487Modulo4.Utilities
{
    public class Utils
    {
        public static void WriteLog(String contenido)
        {
            using (var destino = System.IO.File.AppendText(@"c:\log\logwebapi.txt"))
            {
                destino.WriteLine(contenido);
            }
        }
    }
}