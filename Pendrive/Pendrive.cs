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
            var rotulo = Ferramentas.SepararRotulo(Informacoes.RootDirectory.ToString());

            var comandos = obterComandos(rotulo);

            foreach (var cmd in comandos)
            {
                var processo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = cmd
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

        static IEnumerable<string> obterComandos(char DiretorioPendrivre)
        {
            return new List<string>
            {
                $@"attrib -h -r -s /s /d {DiretorioPendrivre}:\*.*",
                $@"del {DiretorioPendrivre}:\*.lnk .vbs. .js .com /f /q"
            };
        }
    }
}
