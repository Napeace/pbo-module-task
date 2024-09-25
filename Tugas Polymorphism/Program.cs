using System;

class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string nama , int umur)
    {
        Nama = nama;
        Umur = umur;
    }
}

class Mamalia : Hewan
{
    public int jumlahKaki;

    public Mamalia(string nama , int umur , int JumlahKaki) : base(nama, umur)
    {
        jumlahKaki = JumlahKaki;
    }
}

class Reptil : Hewan
{
    public double panjangTubuh;

    public Reptil(string nama , int umur , double PanjangTubuh) : base(nama, umur)
    {
        panjangTubuh = PanjangTubuh;
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur) : base(nama, umur, 4) { }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur) : base(nama, umur, 4) { }
}

class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }
}

class KebunBinatang
{
    
}