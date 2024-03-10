// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class KodePos
{
    private Dictionary<string, string> kodePosDictionary;

    public KodePos()
    {
        // Inisialisasi data kode pos
        kodePosDictionary = new Dictionary<string, string>()
        {
            {"Batununggal", "40266"},
            {"A. Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };
    }

    // Method untuk mendapatkan kode pos berdasarkan kelurahan
    public string GetKodePos(string kelurahan)
    {
        // Cek apakah kelurahan ada dalam daftar
        if (kodePosDictionary.ContainsKey(kelurahan))
        {
            // Jika ada, kembalikan kode posnya
            return kodePosDictionary[kelurahan];
        }
        else
        {
            // Jika tidak, kembalikan pesan bahwa kelurahan tidak ditemukan
            return "Kode pos tidak ditemukan untuk kelurahan " + kelurahan;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Buat objek KodePos
        KodePos kodePos = new KodePos();

        // Buat array yang berisi nama-nama kelurahan
        string[] kelurahanArray = { "Batununggal", "A. Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati",
            "Kebonwaru", "Maleer", "Samoja", "KelurahanTidakDiketahui" };

        // Output dalam bentuk tabel
        Console.WriteLine("{0,-15} {1,-10}", "Kelurahan", "Kode Pos");
        Console.WriteLine("----------------------------------");

        // Iterasi melalui array kelurahan dan tampilkan kode posnya
        foreach (string kelurahan in kelurahanArray)
        {
            Console.WriteLine("{0,-15} {1,-10}", kelurahan, kodePos.GetKodePos(kelurahan));
        }
    }
}

