using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Pendrive
{

    public class Pendrive
    {
        public DriveInfo Informacoes;

        public void Reparar()
        {
            var comandos = obterComandos(Informacoes.RootDirectory.ToString());

            foreach (var cmd in comandos)
            {
                var processo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = cmd,
                    UseShellExecute = false
                };

                Process.Start(processo).WaitForExit();
            }
        }

        public static IEnumerable<DriveInfo> listar()
        {
            var ListaDePendrives = new List<DriveInfo>();
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

        static IEnumerable<string> obterComandos(string DiretorioPendrivre)
        {
            return new List<string>
            {
                $@"/C attrib -h -r -s /s /d {DiretorioPendrivre}*.*",
                $@"/C del {DiretorioPendrivre}*.lnk .vbs. .js .com /f /q"
            };
        }
    }
}
