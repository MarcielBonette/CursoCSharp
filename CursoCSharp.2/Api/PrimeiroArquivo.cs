using System;
using System.IO;

namespace CursoCSharp._2.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    internal class PrimeiroArquivo
    {
        public static void Executar()
        {
            //Quando uso o "~" , ele já identifica as pastas base, e cria direto
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo");
                }
                // Esse comando adiciona mais textos ao bloco. Porém, duplica se executado mais de uma vez.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("");
                    sw.WriteLine("É possivel");
                    sw.WriteLine("adicionar");
                    sw.WriteLine("mais textos!");
                }
            }
        }
    }
}
