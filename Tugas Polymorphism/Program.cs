using System;

class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }
    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }
    public virtual string InfoHewan()
    {
        return $"Nama = {Nama}, Umur = {Umur} tahun";
    }
}

class Mamalia : Hewan
{
    public int jumlahKaki;

    public Mamalia(string nama , int umur , int JumlahKaki) : base(nama, umur)
    {
        jumlahKaki = JumlahKaki;
    }
    public override string Suara()
    {
        return "Mamalia Bersuara";
    }
}

class Reptil : Hewan
{
    public double panjangTubuh;

    public Reptil(string nama , int umur , double PanjangTubuh) : base(nama, umur)
    {
        panjangTubuh = PanjangTubuh;
    }
    public override string Suara()
    {
        return "Reptil Bersuara";
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur) : base(nama, umur, 4) { }
    public override string Suara()
    {
        return "Rawr";
    }
    public void Mengaum()
    {
        Console.WriteLine("Singa Mengaum");
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur) : base(nama, umur, 4) { }
    public override string Suara()
    {
        return "Teeeeeeeeeeeeeeet";
    }
}

class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }
    public override string Suara()
    {
        return "Sssssssssss";
    }
    public void Merayap()
    {
        Console.WriteLine("Ular Merayap");
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }
    public override string Suara()
    {
        return "Buaya Bersuara";
    }
}

class KebunBinatang
{
    private Hewan[] koleksiHewan;
    private int jumlahHewan;

    public KebunBinatang(int kapasitas)
    {
        koleksiHewan = new Hewan[kapasitas];
        jumlahHewan = 0;
    }
    public void TambahHewan(Hewan hewan)
    {
        if (jumlahHewan < koleksiHewan.Length)
        {
            koleksiHewan[jumlahHewan] = hewan;
            jumlahHewan++;
            Console.WriteLine($"{hewan.Nama} telah ditambahkan ke kebun binatang");
        }
        else
        {
            Console.WriteLine("Kebun Binatang penuh.");

        }
    }
    public void DaftarHewan()
    {
        for (int i = 0; i < jumlahHewan; i++)
        {
            Console.WriteLine(koleksiHewan[i].InfoHewan());
        }
    }
}

class Program
{
    static void Main()
    {
        KebunBinatang kebunBinatang = new KebunBinatang(4);
        Singa singa = new Singa("Singa 1", 5);
        Gajah gajah = new Gajah("Gajah 1", 5);
        Ular ular = new Ular("Ular 1", 5, 4);
        Buaya buaya = new Buaya("Buaya 1", 5, 4);

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        Console.WriteLine("\nMethod khusus Singa:");
        singa.Mengaum();
    }
}