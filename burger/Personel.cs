using burger;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkyeri
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string PersonelAdı { get; set; }
        public string PersonelİkinciAdı { get; set; }
        public string PersonelSoyadı { get; set; }
        public string PersonelTamAdı
        {
            get
            {
                string sonuc = PersonelAdı + " " + PersonelSoyadı;
                if (PersonelİkinciAdı.Length > 0)
                {
                    sonuc = PersonelAdı + " " + PersonelİkinciAdı + " " + PersonelSoyadı;

                }

                return sonuc;
            }

        } //Sadece bilgi alabilirsin.
        public decimal BrütMaaş { get; set; }


        //sigorta işçi payı, damga pulu ve işveren sigorta payı 

        public decimal DamgaPulu
        {
            get
            {
                decimal sonuc = 0;
                decimal DamgaPuluOranı = 0.00759m;
                sonuc = BrütMaaş * DamgaPuluOranı;
                return Math.Round(sonuc, 2);
            }
        }
        public decimal İşverenSGKPayı
        {
            get
            {
                decimal sonuc = 0;
                decimal İşverenSGKOranı = 0.205m;
                sonuc = BrütMaaş * İşverenSGKOranı;
                return Math.Round(sonuc, 2);
            }
        }
        public decimal İşçiSGKPayı
        {
            get
            {
                decimal sonuc = 0;
                decimal İşçiSGKOranı = 0.14m;
                sonuc = BrütMaaş * İşçiSGKOranı;
                return Math.Round(sonuc, 2);

            }
        }
        public decimal İşsizlikPayı
        {
            get
            {
                decimal sonuc = 0;
                decimal İşsizlikSGKOranı = 0.02m;
                sonuc = BrütMaaş * İşsizlikSGKOranı;
                return Math.Round(sonuc, 2);


            }
        }
        public DateTime İşeGirişTarihi { get; set; }
        public int AktifYılı
        {
            get
            {
                int sonuc = 0;
                DateTime now = DateTime.Now;
                sonuc = ((now.Date.Year - İşeGirişTarihi.Date.Year));
                return sonuc;
            }
        }

        public int İzinGünSayısı // çalışılan yıl üzerinden hesaplanan izin günü /hatalı sonuc gönderir.
        {
            get
            {
                int sonuc = 0;


                if (AktifYılı >= 1 && AktifYılı <= 5)
                {
                    sonuc = 14;

                }
                else if (AktifYılı < 15)
                {
                    sonuc = 20;
                }
                else
                {
                    sonuc = 26;
                }
                if (AktifYılı == 0)
                {
                    sonuc = 0;

                }

                return sonuc;
            }
        }
        public double HizmetGünSayısı
        {
            get
            {
                double sonuc = 0;
                sonuc = (DateTime.Now - İşeGirişTarihi).TotalDays;
                return sonuc;

            }
        }
        public int GünİzinGünü //Çalışılan gün üzerinden hesaplanan izin günü
        {
            get
            {
                int sonuc = 0;
                int yıl = Convert.ToInt32(HizmetGünSayısı) / 365;
                if (yıl == 0)
                {
                    sonuc = 0;

                }
                else if (yıl <= 5)
                {
                    sonuc = 14;

                }
                else if (yıl < 15)
                {
                    sonuc = 20;
                }
                else
                {
                    sonuc = 26;
                }


                return sonuc;
            }
        }

        public int AktifYıl2
        {
            get
            {
                int sonuc = AktifYılı;
                if (İşeGirişTarihi.DayOfYear < DateTime.Now.DayOfYear)
                {
                    sonuc--;
                }
                return sonuc;
            }
        }
        public int İzinGünSayısı2
        {
            get
            {
                int sonuc = 0;

                if (AktifYıl2 <= 0)
                {
                    sonuc = 0;

                }
                else if (AktifYıl2 <= 5)
                {
                    sonuc = 14;

                }
                else if (AktifYıl2 < 15)
                {
                    sonuc = 20;
                }
                else
                {
                    sonuc = 26;
                }


                return sonuc;
            }
        }

        //public int Hizmetyılsayısı
        //{
        //    get
        //    {
        //        int sonuc = (DateTime.Now.Year - İşeGirişTarihi.Date.Year);
        //        if (İşeGirişTarihi.Month>=DateTime.Today.Month && İşeGirişTarihi.Day>=DateTime.Today.Day)
        //        {
        //            sonuc = (DateTime.Now.Date.Year - İşeGirişTarihi.Date.Year) - 1;
        //        }
        //        return sonuc;
        //    }
        //}

        public int ÇocukSayısı { get; set; }
        public bool EvliMi { get; set; }
        public decimal Agi
        {
            get
            {
                decimal EşParası = 0m;
                decimal ÇocukParası = 0m;
                if (EvliMi)
                {
                    EşParası = (BrütMaaş * 0.1m);
                }
                if (ÇocukSayısı > 0)
                {
                    ÇocukParası = BrütMaaş * 0.05m * ÇocukSayısı;
                }
                return (EşParası + ÇocukSayısı);
            }
        }
        //basit iflerde decimal EşParası=EvliMi ? EşParası=BrütMaaş*0.1m : 0;  
        //Yani Evli ise eşparası=BrütMaaş*0.1m değilse=0
        //public decimal Agi2
        //{
        //    get
        //    {
        //        decimal EşParası = EvliMi ? EşParası = BrütMaaş * 0.1m : 0m;
        //        decimal ÇocukParası = ÇocukSayısı > 0 ? ÇocukParası = BrütMaaş * 0.05m * Convert.ToDecimal(ÇocukSayısı): 0m;
        //        return (EşParası + ÇocukSayısı);
        //    }
        //}
        public DateTime DoğumTarihi { get; set; }
        public int Yaş
        {
            get
            {
                int sonuc = 0;
                if (DoğumTarihi.Month >= DateTime.Now.Month && DoğumTarihi.Day >= DateTime.Now.Day)
                {
                    sonuc = DateTime.Now.Year - DoğumTarihi.Year - 1;
                }
                else
                {
                    sonuc = DateTime.Now.Year - DoğumTarihi.Year;
                }
                return sonuc;
            }
        }
        public string Kuşak
        {
            get
            {
                string sonuc = ""; //3 altı bebek 12 altı cocuk 18 altı genç 40 altı yetişkn 70 altı yaşlı değilse çok yaşlı
                switch (Yaş)
                {
                    case < 3:
                        sonuc = "Bebek";
                        break;
                    case < 12:
                        sonuc = "Çocuk";
                        break;
                    case < 18:
                        sonuc = "Genç";
                        break;
                    case < 40:
                        sonuc = "Yetişkin";
                        break;
                    case < 70:
                        sonuc = "Yaşlı";
                        break;
                    default:
                        sonuc = "Çok Yaşlı";
                        break;
                }
                return sonuc;
            }
        }
        //sonuc = Yaş switch
        //        {
        //            < 3 => "Bebek",
        //            < 12 => "Çocuk",
        //            < 18 => "Genç",
        //            < 40 => "Yetişkin",
        //            < 70 => "Yaşlı",
        //            _ => "Çok Yaşlı",
        //        };
        //        return sonuc;
        public int KaçGünYaşamış
        {
            get
            {
                return metot.kaçGünYaşamış(DoğumTarihi);
            }
        }
        public string Burç
        {
            get { return metot.burçBul(DoğumTarihi); }
        }
        public int BoyCm { get; set; }
        public int KiloKg { get; set; }
        public double IBS
        {
            get
            {
                return metot.ibs(KiloKg);
            }
        }
        public double Inç
        {
            get
            {
                return metot.inç(BoyCm);
            }
        }
        public decimal BedenKitleEndeksi
        {
            get
            {
                decimal boyM = BoyCm / 100m;
                return KiloKg / (boyM * boyM);
            }
        }
        public string KanGrubu { get; set; }
        public bool ErkekMi { get; set; }
        public string VücutDurumu
        {
            get
            {
                return metot.vücutDurumu(BedenKitleEndeksi);
            }
        }
        public string KanBağış
        {
            get
            {
                return metot.kanBağış(KanGrubu);
            }
        }
        

      

    }
}