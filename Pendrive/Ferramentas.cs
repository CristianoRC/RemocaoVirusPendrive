using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Pendrive
{
    static public class Ferramentas
    {

        static public List<DriveInfo> listarPendrives()
        {
            List<DriveInfo> ListaDePendrives = new List<DriveInfo>();

            var Drives = DriveInfo.GetDrives();
            foreach (var driver in Drives)
            {
                if (driver.IsReady && (driver.DriveType == DriveType.Removable))
                {
                    ListaDePendrives.Add(driver);
                }
            }

            return ListaDePendrives;
        }

        static private void CriarArquivoBat(char DiretorioPendrivre)
        {
            StreamWriter Sw = null;

            try
            {
                if (File.Exists($"{Path.GetTempPath()}/Executar.bat"))
                {
                    File.Delete($"{Path.GetTempPath()}/Executar.bat");
                }

                Sw = new StreamWriter($"{Path.GetTempPath()}/Executar.bat");

                Sw.WriteLine($@"attrib -h -r -s /s /d {DiretorioPendrivre}:\*.*");
                Sw.WriteLine("*.lnk");
            }
            catch (Exception)
            {

            }
            finally
            {
                if (Sw != null)
                {
                    Sw.Close();
                }
            }
        }

        public static void RepararPendrive(DriveInfo InformacoesPendrive)
        {
            char rotulo = SepararRotulo(InformacoesPendrive.RootDirectory.ToString());

            CriarArquivoBat(rotulo);

            Process.Start($"{Path.GetTempPath()}/Executar.bat").WaitForExit();
        }

        private static char SepararRotulo(string RotuloCompleto)
        {
            char saida;

            string[] Linha = new string[2];

            Linha = RotuloCompleto.Split(':');

            saida = Linha[0].ToCharArray()[0];


            return saida;
        }
    }
}