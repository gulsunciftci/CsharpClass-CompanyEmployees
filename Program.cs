using System;
using System.Text;
namespace csharpclass
{
class Employee{
        
        static void Main(string[] args){

            Sirket sirket1=new Sirket(); //Her sirket icin bir nesne olusturuldu
            sirket1.Unvan="EKOM";
            Sirket sirket2=new Sirket();
            sirket2.Unvan="TRENDYOL";
            Sirket sirket3=new Sirket();
            sirket3.Unvan="GETİR"; 
            string? satir = "";

            DateTime suan=DateTime.Now; //DateTime tipinde değisken olusturuldu
            //simdiki zamani getirmek icin DateTime.Now özelliği kullanildi

            StreamReader sr = new StreamReader("PersonelVeri.txt");  
            //StreamReader sınıfından bir örnek alindi ve önceden olusturulmus bir dosya ile islem yapilacagi belirtildi. 

            while (true)
            {
                satir = sr.ReadLine(); //Dosya satirini okur ve String olarak döndürür
 
                if (satir == null)
                {
                    break; //satirlar bittigi zaman break ile döngüden cikar
                }
                string[] bilgiler = satir.Split('-'); //satirlari '-' ile split eder
                if(bilgiler[2]==sirket1.Unvan){
                OrnektVeriOlustur(bilgiler[0],Convert.ToDouble(bilgiler[1]),bilgiler[3],bilgiler[4],sirket1,suan);
                }
                else if(bilgiler[2]==sirket2.Unvan){
                OrnektVeriOlustur(bilgiler[0],Convert.ToDouble(bilgiler[1]),bilgiler[3],bilgiler[4],sirket2,suan);
                }
                else if(bilgiler[2]==sirket3.Unvan){
                OrnektVeriOlustur(bilgiler[0],Convert.ToDouble(bilgiler[1]),bilgiler[3],bilgiler[4],sirket3,suan);
                }
            }
            sr.Close();
            
            Yazdir(sirket1);
            Yazdir(sirket2);
            Yazdir(sirket3);
        }
        static void Yazdir(Sirket sirket)
        {

            sirket.Personeller?.ForEach(delegate(Personel e) { //foreach ile personeller listesinin ici gezildi
         
            Console.WriteLine("\n"+"ŞİRKET: "+sirket.Unvan+"    ADSOYAD: "+e.PAdSoyad+"    ÇALIŞTIĞITOPLAMAY: "+e.PCalistigiAy+"   MAAŞ: "+e.PMaas+"    İŞEGİRİŞTARİHİ: "+e.PGirisTarihi?.ToString("dd/MM/yyyy")+"    DOĞUMTARİHİ: "+e.PDogumTarihi?.ToString("dd/MM/yyyy"));
            });
        }
        static void OrnektVeriOlustur(String AdSoyad, Double Maas,String GirisTarihi,String DogumTarihi,Sirket sirkett,DateTime suan)
        {
           sirkett.AddPersonel(AdSoyad,Maas,GirisTarihi,DogumTarihi,sirkett,suan);
        }

}

}