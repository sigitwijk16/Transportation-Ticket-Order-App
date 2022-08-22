using System;
using System.Collections.Generic;
using System.Text;

namespace TiketTransportasi
{
    class DataDiri
    {
        public string nama;
        public long nik;
        public string nomerHP;
        public string nomerKartuVaksin;
        public string alamatDesa;
        public string alamatRT;
        public string alamatRW;
        public string alamatKec;
        public string alamatKab;
        public string alamatProv;
        public string catatan;
        public string alamatDesaKantor;
        public string alamatRTKantor;
        public string alamatRWKantor;
        public string alamatKecKantor;
        public string alamatKabKantor;
        public string alamatProvKantor;
        public string nomerKartuVaksin3;

        public void InputDataWajib()
        {
            InputNama();
            InputNIK();
            InputNomerHP();
            InputVaksin();
            InputAlamatDesa();
            InputAlamatRT();
            InputAlamatRW();
            InputAlamatKec();
            InputAlamatKab();
            InputAlamatProv();

        }

        public void InputAlamatKantor()
        {
            InputAlamatDesaKantor();
            InputAlamatRTKantor();
            InputAlamatRWKantor();
            InputAlamatKecKantor();
            InputAlamatKabKantor();
            InputAlamatProvKantor();
        }

        public DataDiri(string nama, long nik, string nomerHP, string nomerKartuVaksin, string alamatRT, string alamatRW, string alamatKec, string alamatKab, string alamatProv, string catatan)
        {
            this.nama = nama;
            this.nik = nik;
            this.nomerHP = nomerHP;
            this.nomerKartuVaksin = nomerKartuVaksin;
            this.alamatRT = alamatRT;
            this.alamatRW = alamatRW;
            this.alamatKec = alamatKec;
            this.alamatKab = alamatKab;
            this.alamatProv = alamatProv;
            this.catatan = catatan;
        }

        public void InputNama()
        {
            Console.Write("\t\t\tMasukkan nama anda: ");
            nama = Console.ReadLine();
        }

        public void InputNIK()
        {
            Console.Write("\t\t\tMasukkan NIK anda: ");
            nik = Convert.ToInt64(Console.ReadLine());
        }

        public void InputNomerHP()
        {
            Console.Write("\t\t\tMasukkan nomor HP anda: ");
            nomerHP = Console.ReadLine();
        }


        public void InputVaksin()
        {
            Console.Write("\t\t\tMasukkan Nomor Kartu Vaksin anda: ");
            nomerKartuVaksin = Console.ReadLine();
        }

        public void InputAlamatDesa()
        {
            Console.Write("\t\t\tMasukkan nama Desa rumah anda: ");
            alamatDesa = Console.ReadLine();
        }

        public void InputAlamatRT()
        {
            Console.Write("\t\t\tMasukkan nomor RT rumah anda: ");
            alamatRT = Console.ReadLine();
        }

        public void InputAlamatRW()
        {
            Console.Write("\t\t\tMasukkan nomor RW rumah anda: ");
            alamatRW = Console.ReadLine();
        }

        public void InputAlamatKec()
        {
            Console.Write("\t\t\tMasukkan Kecamatan rumah anda: ");
            alamatKec = Console.ReadLine();
        }

        public void InputAlamatKab()
        {
            Console.Write("\t\t\tMasukkan Kabupaten/Kota rumah anda: ");
            alamatKab = Console.ReadLine();
        }

        public void InputAlamatProv()
        {
            Console.Write("\t\t\tMasukkan Provinsi rumah anda: ");
            alamatProv = Console.ReadLine();
        }

        public void InputCatatan()
        {
            Console.Write("\t\t\tMasukkan catatan anda: ");
            catatan = Console.ReadLine();
        }

        public void InputAlamatDesaKantor()
        {
            Console.Write("\t\t\tMasukkan nama Desa kantor anda: ");
            alamatDesaKantor = Console.ReadLine();
        }

        public void InputAlamatRTKantor()
        {
            Console.Write("\t\t\tMasukkan nomor RT kantor anda: ");
            alamatRTKantor = Console.ReadLine();
        }

        public void InputAlamatRWKantor()
        {
            Console.Write("\t\t\tMasukkan nomor RW kantor anda: ");
            alamatRWKantor = Console.ReadLine();
        }

        public void InputAlamatKecKantor()
        {
            Console.Write("\t\t\tMasukkan Kecamatan kantor anda: ");
            alamatKecKantor = Console.ReadLine();
        }

        public void InputAlamatKabKantor()
        {
            Console.Write("\t\t\tMasukkan Kabupaten/Kota kantor anda: ");
            alamatKabKantor = Console.ReadLine();
        }

        public void InputAlamatProvKantor()
        {
            Console.Write("\t\t\tMasukkan Provinsi kantor anda: ");
            alamatProvKantor = Console.ReadLine();
        }

        public void InputVaksin3()
        {
            Console.Write("\t\t\tMasukkan Nomor Kartu Vaksin 3 anda: ");
            nomerKartuVaksin3 = Console.ReadLine();
        }
    }
}
