using System;

namespace TiketTransportasi
{
    class Program
    {
        static void Main(string[] args)
        {
            string konfirmData;

            DataDiri datadiri = new DataDiri(" ", 0, " ", " ", " ", " ", " ", " ", " ", " ");
            GenericDataDiri<DataDiri> datadiri1 = new GenericDataDiri<DataDiri>(datadiri);
            Confirmation conf = new Confirmation(datadiri, datadiri1);

            conf.showTitle();

        inputUlang:
            Console.WriteLine();
            Console.WriteLine("\t\t\tMohon masukkan data diri anda");
            Console.WriteLine();

            datadiri.InputDataWajib();
            conf.menuOpsional();

            Console.WriteLine();
            Console.WriteLine("\t\t\tMohon konfirmasi data diri anda");
            Console.WriteLine();

            conf.showDataWajib();
            conf.showDataOpsional();

            Console.WriteLine();
            Console.Write("\t\t\tApakah data diri anda sudah benar? y/n: ");
            konfirmData = Console.ReadLine();
            if (konfirmData == "N" || konfirmData == "n")
            {
                goto inputUlang;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("\t\t\tTerimakasih telah menggunakan jasa transportasi kami, silakan menunggu tiket anda dicetak.");
                Console.WriteLine();
            }
        }
    }
}
