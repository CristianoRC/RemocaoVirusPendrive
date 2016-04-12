using System;
using System.Collections.Generic;
using System.IO;

namespace Pendrive
{
    static public class Ferramentas
    {
        static public void VerificarPastaTemp()
        {
            if (Directory.Exists("Temp"))
            {
                ExcluirTemp();
                CriarTemp();
            }
            else
            {
                CriarTemp();
            }
        }

        static public void ExcluirTemp()
        {
            try
            {
                Directory.Delete("Temp", true);
            }
            catch (Exception)
            {


            }

        }

        static public void CriarTemp()
        {
            try
            {
                Directory.CreateDirectory("Temp");
            }
            catch (Exception)
            {

                throw;
            }
        }

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
                if (File.Exists("Temp/Executar.bat"))
                {
                    File.Delete("Temp/Executar.bat");
                }

                Sw = new StreamWriter("Temp/Executar.bat");

                Sw.WriteLine($@"attrib -h -r -s /s /d {DiretorioPendrivre}:\*.*");
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
            CriarArquivoBat(SepararRotulo(InformacoesPendrive.RootDirectory.ToString()));
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