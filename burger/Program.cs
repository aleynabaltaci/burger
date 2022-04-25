using burger;
using parkyeri;
using System.Collections.Generic;

List<Personel> personeller = new List<Personel>{ new Personel { PersonelID = 1, PersonelAdı = "Ali",PersonelİkinciAdı = "Ahmet",PersonelSoyadı="Yılmaz" ,BrütMaaş=5165.807m,İşeGirişTarihi=Convert.ToDateTime("21.12.2001"),ÇocukSayısı=0,EvliMi=false,DoğumTarihi=Convert.ToDateTime("19.05.1942"),BoyCm=167,KiloKg=56,KanGrubu="A",ErkekMi=true},
                                                 new Personel { PersonelID = 2, PersonelAdı = "Ayşe",PersonelİkinciAdı = "Pelin",PersonelSoyadı="Yılmaz", BrütMaaş=7878.157m,İşeGirişTarihi=Convert.ToDateTime("18.11.2015"),ÇocukSayısı=4,EvliMi=true,DoğumTarihi=Convert.ToDateTime("20.12.1967"),BoyCm=173,KiloKg=55,KanGrubu="AB",ErkekMi=false},
                                                 new Personel { PersonelID = 3, PersonelAdı = "Yunus",PersonelİkinciAdı = "Emre",PersonelSoyadı="Fenerci" ,BrütMaaş=9152.353m,İşeGirişTarihi=Convert.ToDateTime("05.08.2019"),ÇocukSayısı=2,EvliMi=true,DoğumTarihi=Convert.ToDateTime("05.08.2020"),BoyCm=181,KiloKg=75,KanGrubu="0",ErkekMi=true},
                                                 new Personel { PersonelID = 4, PersonelAdı = "Ayşe",PersonelİkinciAdı = "Fatma",PersonelSoyadı="Kantar" ,BrütMaaş=8174.154m,İşeGirişTarihi=Convert.ToDateTime("21.09.2020"),ÇocukSayısı=1,EvliMi=true,DoğumTarihi=Convert.ToDateTime("23.09.1980"),BoyCm=155,KiloKg=62,KanGrubu="B",ErkekMi=false},
                                                 new Personel { PersonelID = 5, PersonelAdı = "Mine",PersonelİkinciAdı = "Reyhan",PersonelSoyadı="Bektaş" ,BrütMaaş=4546.335m,İşeGirişTarihi=Convert.ToDateTime("19.12.2021"),ÇocukSayısı=0,EvliMi=false,DoğumTarihi=Convert.ToDateTime("13.07.1983"),BoyCm=178,KiloKg=72,KanGrubu="AB",ErkekMi=false},
                                                 new Personel { PersonelID = 6, PersonelAdı = "Aleyna",PersonelİkinciAdı = "" ,PersonelSoyadı="Baltacı",BrütMaaş=11546.21m,İşeGirişTarihi=Convert.ToDateTime("30.05.2018"),ÇocukSayısı=0,EvliMi=false,DoğumTarihi=Convert.ToDateTime("21.09.1997"),BoyCm=162,KiloKg=57,KanGrubu="A",ErkekMi=false},
                                                 new Personel { PersonelID = 7, PersonelAdı = "Büşra",PersonelİkinciAdı = "Mira" ,PersonelSoyadı="Duman",BrütMaaş=7682.12m,İşeGirişTarihi=Convert.ToDateTime("28.02.2018"),ÇocukSayısı=0,EvliMi=true,DoğumTarihi=Convert.ToDateTime("16.09.1997"),BoyCm=175,KiloKg=86,KanGrubu="A",ErkekMi=false},
                                                 new Personel { PersonelID = 8, PersonelAdı = "Sude",PersonelİkinciAdı = "",PersonelSoyadı="Çelik" ,BrütMaaş=12562.30m,İşeGirişTarihi=Convert.ToDateTime("08.08.2011"),ÇocukSayısı=2,EvliMi=true,DoğumTarihi=Convert.ToDateTime("19.05.1972"),BoyCm=156,KiloKg=57,KanGrubu="0",ErkekMi=false},
                                               };

foreach (Personel personel in personeller)
{
    //Console.WriteLine(personel.TamAdı + "'ın maaşı:" + personel.BrütMaaş + "'dır.");
    //Console.WriteLine("Ad Soyad: " + personel.PersonelTamAdı + " Damga Pulu Oranı: " + personel.DamgaPulu + " İşveren Sigorta Payı: " + personel.İşverenSGKPayı + " İşçi Sigorta Payı " + personel.İşçiSGKPayı + " İşsizlik Sigorta Primi: " + personel.İşsizlikPayı + " İşe Giriş Tarihi" + personel.İşeGirişTarihi.ToShortDateString());
    //Console.WriteLine(personel.AktifYılı);
    Console.WriteLine(personel.KanBağış);
}

//Console.WriteLine("Doğum tarihi giriniz:");
//DateTime sonuc=Convert.ToDateTime( Console.ReadLine());
//Console.WriteLine(metot.kaçGünYaşamış(sonuc));
//Console.Read();



//foreach (Personel personel in personeller)
//{
//    if (personel.KanGrubu == "A" || personel.KanGrubu=="0")
//    {
//        Console.WriteLine(personel.PersonelTamAdı);
       
//    }
    
//}
