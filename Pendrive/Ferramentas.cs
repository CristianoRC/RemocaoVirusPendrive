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
    }
}