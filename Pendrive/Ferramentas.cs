namespace Pendrive
{
    internal static class Ferramentas
    {
        internal static char SepararRotulo(string RotuloCompleto)
        {
            char saida;

            var Linha = new string[2];

            Linha = RotuloCompleto.Split(':');

            saida = Linha[0].ToCharArray()[0];

            return saida;
        }

        internal static float ConverterEmGigabytes(float bytes)
        {
            return (bytes / 1073741824);
        }
    }
}