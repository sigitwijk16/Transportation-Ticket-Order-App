using System;
using System.Collections.Generic;
using System.Text;

namespace TiketTransportasi
{
    class Confirmation
    {
        DataDiri datadiri;
        GenericDataDiri<DataDiri> datadiri1;

        string konfirmasi, konfirmasi1, konfirmasi2;
        public bool pakaiCatatan = false;
        public bool pakaiAlamatKantor = false;
        public bool pakaiVaksin3 = false;

        public Confirmation(DataDiri datadiri, GenericDataDiri<DataDiri> datadiri1)
        {
            this.datadiri = datadiri;
            this.datadiri1 = datadiri1;
        }

        public void showTitle()
        {
            Console.WriteLine("\t\t\t________________________________________");
            Console.WriteLine("\t\t\t|                                       |");
            Console.WriteLine("\t\t\t|      Pemesanan Tiket Transportasi     |");
            Console.WriteLine("\t\t\t|_______________________________________|");
        }

        public void konfirmCatatan()
        {
            Console.Write("\t\t\tApakah anda ingin menambah catatan?(opsional) y/n: ");
            konfirmasi = Console.ReadLine();
            if (konfirmasi == "y" || konfirmasi == "Y")
            {
                datadiri.InputCatatan();
                pakaiCatatan = true;
            }
        }

        public void konfirmKantor()
        {
            Console.Write("\t\t\tApakah anda ingin menambah alamat kantor?(opsional) y/n: ");
            konfirmasi1 = Console.ReadLine();
            if (konfirmasi1 == "y" || konfirmasi1 == "Y")
            {
                datadiri.InputAlamatKantor();
                pakaiAlamatKantor = true;
            }
        }

        public void konfirmVaksin3()
        {
            Console.Write("\t\t\tApakah anda ingin menambah Nomor Kartu Vaksin 3?(opsional) y/n: ");
            konfirmasi2 = Console.ReadLine();
            if (konfirmasi2 == "y" || konfirmasi2 == "Y")
            {
                datadiri.InputVaksin3();
                pakaiVaksin3 = true;
            }
        }
         public void showCatatan()
        {
            if (pakaiCatatan == true)
            {
                Console.WriteLine("\t\t\tCatatan              : {0}", datadiri1.value.catatan);
            }
        }

        public void showAlamatKantor()
        {
            if (pakaiAlamatKantor == true)
            {
                Console.WriteLine("\t\t\tAlamat Kantor        : Desa {0} RT/RW {1}/{2}, Kec. {3}, Kab. {4}, Prov. {5}", datadiri1.value.alamatDesaKantor, datadiri1.value.alamatRTKantor, datadiri1.value.alamatRWKantor, datadiri1.value.alamatKecKantor, datadiri1.value.alamatKabKantor, datadiri1.value.alamatProvKantor);
            }
        }

        public void showVaksin3()
        {
            if (pakaiVaksin3 == true)
            {
                Console.WriteLine("\t\t\tNomor Kartu Vaksin 3 : {0}", datadiri1.value.nomerKartuVaksin3);
            }
        }

        public void menuOpsional()
        {
            konfirmCatatan();
            konfirmKantor();
            konfirmVaksin3();
        }

        public void showDataWajib()
        {
            Console.WriteLine("\t\t\tNama                 : {0} \n\t\t\tNIK                  : {1} \n\t\t\tNomor HP             : {2} \n\t\t\tNomor Kartu Vaksin   : {3} \n\t\t\tAlamat Rumah         : Desa {4} RT/RW {5}/{6}, Kec. {7}, Kab. {8}, Prov. {9}", datadiri1.value.nama, datadiri1.value.nik, datadiri1.value.nomerHP, datadiri1.value.nomerKartuVaksin, datadiri1.value.alamatDesa, datadiri1.value.alamatRT, datadiri1.value.alamatRW, datadiri1.value.alamatKec, datadiri1.value.alamatKab, datadiri1.value.alamatProv);
        }

        public void showDataOpsional()
        {
            showCatatan();
            showAlamatKantor();
            showVaksin3();
        }
    }
}
