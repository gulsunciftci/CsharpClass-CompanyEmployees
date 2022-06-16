using System;
using System.Text;
namespace csharpclass
{

 public class Sirket
{
    public String? Unvan { get; set; } //Bir özelligin degeri okunmak istenildiginde o özellige ait GET metodu calisir.
    public String? VergiNo { get; set; } //Bir özellige atama yapılmak istenildiginde o özellige ait SET metodu calisir.
    public String? Adres { get; set; }  //SET metodu icerisinde value anahtar sözcüğü ile erisilir.
    public String? Yetkili { get; set; } //Özellige atanacak deger hangi türden ise value da o türden olur.
    public List<Personel>? Personeller= new List<Personel>();
    public void AddPersonel(String AdSoyad, Double Maas,String GirisTarihi,String DogumTarihi,Sirket sirket,DateTime suan)
    {
        Personeller?.Add(new Personel(AdSoyad, Maas,GirisTarihi,DogumTarihi,suan));  
        //personeller listesinin icine personel nesnesini atıyoruz
    }
}
public class Personel
{    
    public String? PAdSoyad { get; set; }
    public int PCalistigiAy { get; set; }

    public Double PMaas { get; set; }  

    public DateTime? PGirisTarihi=new DateTime();
    public DateTime? PDogumTarihi=new DateTime();
    public Personel(String AdSoyad, Double Maas,String GirisTarihi,String DogumTarihi,DateTime suan) //yapici
    {
            PAdSoyad=AdSoyad;
            PMaas = Maas; 
            PGirisTarihi=DateTime.Parse(GirisTarihi); //parse ile string olarak gelen tarih bilgisi DateTime'a dönüstürüldü
            PDogumTarihi=DateTime.Parse(DogumTarihi);
            PCalistigiAy=Math.Abs(suan.Month-DateTime.Parse(GirisTarihi).Month) + 12 * (suan.Year-DateTime.Parse(GirisTarihi).Year);
            //ay bilgisi hesaplandi
    }
}
}