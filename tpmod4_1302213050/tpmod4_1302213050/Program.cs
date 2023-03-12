// See https://aka.ms/new-console-template for more information
internal class Program
{
    public enum Kelurahan
    {
        Batununggal,
        Kujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer,
        Samoja
    }

    public class KodePos_1302213050
    {
        public static int getKodePos(Kelurahan kelurahan)
        {
            int[] isiKodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            int inputKodePos = (int)kelurahan;
            return isiKodePos[inputKodePos];
        }
    }
    public static void Main(string[] args)
    {
        Kelurahan kelurahan = Kelurahan.Samoja;
        int kodePos = KodePos_1302213050.getKodePos(kelurahan);
        Console.WriteLine("Kelurahan: " + kelurahan + "\nKode Pos: " + kodePos);

        Console.WriteLine("----------------------------------------------------");
    }
}