using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CursoCScharp.API {

    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home= (Environment.OSVersion.Platform == PlatformID.Unix||
               Environment.OSVersion.Platform == PlatformID.Other)
               ? Environment.GetEnvironmentVariable("HOME")
               : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    internal class PrimeiroArquivo {
        public static void Executar() {
            var parth = @"~/primeiro_arquivo.txt".ParseHome();
            
            if(!File.Exists(parth)) {
                using (StreamWriter sw = File.CreateText(parth)) {
                    sw.WriteLine("Tomar no cu Corinthias");
                    sw.WriteLine("Flamengo vsf");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("Arquvio");
                }
            }
        }
    }
}
