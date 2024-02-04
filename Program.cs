using System;

namespace GaCha
{
    class Program
    {
        static void Main()
        {
            string[] namaPelapor = new string[10];
            string[] nimPelapor = new string[10];
            string[] barangHilang = new string[10];
            string[] ciriBarangHilang = new string[10];
            string[] lokasiHilang = new string[10];
            string[] tanggalHilang = new string[10];
            string[] kontakPelapor = new string[10];
            string[] namaPenemu = new string[10];
            string[] nimPenemu = new string[10];
            string[] barangDitemukan = new string[10];
            string[] ciriBarangDitemukan = new string[10];
            string[] lokasiDitemukan = new string[10];
            string[] tanggalNemu = new string[10];
            string[] kontakPenemu = new string[10];
            bool[] barangDitemukanStatus = new bool[10];

            int indexLapor = 0;
            int indexNemu = 0;
            int pilihan;

            do
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("|              Aplikasi GoFind              |");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("|    1. Buat Laporan Kehilangan Barang      |");
                Console.WriteLine("|    2. Buat Laporan Penemuan Barang        |");
                Console.WriteLine("|    3. Informasi Barang Hilang             |");
                Console.WriteLine("|    4. Informasi Penemuan Barang           |");
                Console.WriteLine("|    5. Hapus Laporan                       |");
                Console.WriteLine("|    0. Keluar                              |");
                Console.WriteLine("---------------------------------------------");
                Console.Write("Masukkan Nomor Pilihan Anda: ");
                pilihan = Convert.ToInt32(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("-------- Laporan Barang Hilang --------");
                        Console.Write("Masukkan nama Anda: ");
                        string nama = Console.ReadLine();
                        Console.Write("Masukkan NIM Anda: ");
                        string nim = Console.ReadLine();
                        Console.Write("Barang apa yang hilang: ");
                        string barang = Console.ReadLine();
                        Console.Write("Masukkan ciri ciri barang: ");
                        string ciri = Console.ReadLine();
                        Console.Write("Dimana Anda merasa kehilangan barang: ");
                        string lokasi = Console.ReadLine();
                        Console.Write("Masukkan Tanggal Hilang (dd/mm/yyyy): ");
                        string tanggal = Console.ReadLine();
                        Console.Write("Masukkan kontak Anda yang bisa dihubungi: ");
                        string kontak = Console.ReadLine();

                        namaPelapor[indexLapor] = nama;
                        nimPelapor[indexLapor] = nim;
                        barangHilang[indexLapor] = barang;
                        ciriBarangHilang[indexLapor] = ciri;
                        lokasiHilang[indexLapor] = lokasi;
                        tanggalHilang[indexLapor] = tanggal;
                        kontakPelapor[indexLapor] = kontak;

                        Console.WriteLine("Laporan berhasil disimpan!");
                        indexLapor++;
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("-------- Laporan Penemuan Barang --------");
                        Console.Write("Masukkan nama Anda: ");
                        nama = Console.ReadLine();
                        Console.Write("Masukkan NIM Anda: ");
                        nim = Console.ReadLine();
                        Console.Write("Barang apa yang ditemukan: ");
                        barang = Console.ReadLine();
                        Console.Write("Masukkan ciri ciri barang: ");
                        ciri = Console.ReadLine();
                        Console.Write("Dimana Anda menemukan barang: ");
                        lokasi = Console.ReadLine();
                        Console.Write("Masukkan Tanggal (dd/mm/yyyy): ");
                        tanggal = Console.ReadLine();
                        Console.Write("Masukkan kontak Anda yang bisa dihubungi: ");
                        kontak = Console.ReadLine();

                        namaPenemu[indexNemu] = nama;
                        nimPenemu[indexNemu] = nim;
                        barangDitemukan[indexNemu] = barang;
                        ciriBarangDitemukan[indexNemu] = ciri;
                        lokasiDitemukan[indexNemu] = lokasi;
                        tanggalNemu[indexNemu] = tanggal;
                        kontakPenemu[indexNemu] = kontak;
                        barangDitemukanStatus[indexNemu] = false;

                        Console.WriteLine("Laporan berhasil disimpan!");
                        indexNemu++;
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("-------- Informasi Barang Hilang --------");
                        if (indexLapor == 0)
                        {
                            Console.WriteLine("Tidak ada laporan barang hilang.");
                        }
                        else
                        {
                            for (int i = 0; i < indexLapor; i++)
                            {
                                if (!barangDitemukanStatus[i])
                                {
                                    Console.WriteLine("Laporan " + (i + 1));
                                    Console.WriteLine("Nama: " + namaPelapor[i]);
                                    Console.WriteLine("NIM: " + nimPelapor[i]);
                                    Console.WriteLine("Barang hilang: " + barangHilang[i]);
                                    Console.WriteLine("Ciri ciri barang: " + ciriBarangHilang[i]);
                                    Console.WriteLine("Lokasi: " + lokasiHilang[i]);
                                    Console.WriteLine("Tanggal: " + tanggalHilang[i]);
                                    Console.WriteLine("Kontak Pemilik: " + kontakPelapor[i]);
                                    Console.WriteLine("Jika Anda menemukan barang tersebut. Silahkan hubungi kontak yang tertera.");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("-------- Informasi Penemuan Barang --------");
                        if (indexNemu == 0)
                        {
                            Console.WriteLine("Tidak ada laporan barang ditemukan.");
                        }
                        else
                        {
                            for (int i = 0; i < indexNemu; i++)
                            {
                                Console.WriteLine("Laporan " + (i + 1));
                                Console.WriteLine("Nama: " + namaPenemu[i]);
                                Console.WriteLine("NIM: " + nimPenemu[i]);
                                Console.WriteLine("Barang ditemukan: " + barangDitemukan[i]);
                                Console.WriteLine("Ciri ciri barang: " + ciriBarangDitemukan[i]);
                                Console.WriteLine("Lokasi: " + lokasiDitemukan[i]);
                                Console.WriteLine("Tanggal: " + tanggalNemu[i]);
                                Console.WriteLine("Kontak Penemu: " + kontakPenemu[i]);
                                Console.WriteLine("Jika Anda pemilik barang tersebut. Silahkan hubungi kontak yang tertera.");
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("-------- Hapus Laporan --------");
                        Console.WriteLine("1. Hapus Laporan Barang Hilang");
                        Console.WriteLine("2. Hapus Laporan Penemuan Barang");
                        Console.Write("Masukkan nomor pilihan: ");
                        int subPilihan = Convert.ToInt32(Console.ReadLine());

                        switch (subPilihan)
                        {
                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("-------- Hapus Laporan Barang Hilang --------");
                                Console.Write("Masukkan nomor laporan yang ingin dihapus: ");
                                int nomorHapusHilang = Convert.ToInt32(Console.ReadLine());

                                if (nomorHapusHilang >= 1 && nomorHapusHilang <= indexLapor)
                                {
                                    if (!barangDitemukanStatus[nomorHapusHilang - 1])
                                    {
                                        for (int i = nomorHapusHilang - 1; i < indexLapor - 1; i++)
                                        {
                                            namaPelapor[i] = namaPelapor[i + 1];
                                            nimPelapor[i] = nimPelapor[i + 1];
                                            barangHilang[i] = barangHilang[i + 1];
                                            ciriBarangHilang[i] = ciriBarangHilang[i + 1];
                                            lokasiHilang[i] = lokasiHilang[i + 1];
                                            tanggalHilang[i] = tanggalHilang[i + 1];
                                            kontakPelapor[i] = kontakPelapor[i + 1];
                                            barangDitemukanStatus[i] = barangDitemukanStatus[i + 1];
                                        }

                                        indexLapor--;
                                        Console.WriteLine($"Laporan {nomorHapusHilang} berhasil dihapus.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Laporan tidak dapat dihapus karena barang sudah ditemukan.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nomor laporan tidak valid.");
                                }
                                break;

                            case 2:
                                Console.WriteLine();
                                Console.WriteLine("-------- Hapus Laporan Penemuan Barang --------");
                                Console.Write("Masukkan nomor laporan yang ingin dihapus: ");
                                int nomorHapusPenemuan = Convert.ToInt32(Console.ReadLine());

                                if (nomorHapusPenemuan >= 1 && nomorHapusPenemuan <= indexNemu)
                                {
                                    int nomorPenemuan = nomorHapusPenemuan - 1;
                                    for (int i = nomorPenemuan; i < indexNemu - 1; i++)
                                    {
                                        namaPenemu[i] = namaPenemu[i + 1];
                                        nimPenemu[i] = nimPenemu[i + 1];
                                        barangDitemukan[i] = barangDitemukan[i + 1];
                                        ciriBarangDitemukan[i] = ciriBarangDitemukan[i + 1];
                                        lokasiDitemukan[i] = lokasiDitemukan[i + 1];
                                        tanggalNemu[i] = tanggalNemu[i + 1];
                                        kontakPenemu[i] = kontakPenemu[i + 1];
                                        barangDitemukanStatus[i] = barangDitemukanStatus[i + 1];
                                    }
                                    indexNemu--;
                                    Console.WriteLine($"Laporan {nomorHapusPenemuan} berhasil dihapus.");
                                }
                                else
                                {
                                    Console.WriteLine("Nomor laporan tidak valid.");
                                }
                                break;

                            default:
                                Console.WriteLine("Pilihan tidak valid. Silakan pilih angka 1 atau 2");
                                break;
                        }
                        break;

                    case 0:
                        Console.WriteLine("Terima kasih telah menggunakan program ini!");
                        break;

                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan pilih angka 1-5");
                        break;
                }
                Console.ReadLine();
            } while (pilihan != 0);
        }
    }
}