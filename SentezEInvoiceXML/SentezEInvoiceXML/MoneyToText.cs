using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentezEInvoiceXML {
    // Sayının aralığını ve karşılık gelecek metnin sınıfını oluşturuyoruz.
    //class MoneyDefiniton {
    //    public long RangeStart { get; set; }
    //    public long RangeEnd { get; set; }
    //    public string Text { get; set; }
    //}

    //public class MoneyTalks {
    //   private static List<MoneyDefiniton> _moneyDefinition;
       
    //   public static void MoneyDefinitioninit() {
    //        _moneyDefinition = new List<MoneyDefiniton>();
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 1,
    //            RangeEnd = 1,
    //            Text = "Bir"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 2,
    //            RangeEnd = 2,
    //            Text = "iki"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 3,
    //            RangeEnd = 3,
    //            Text = "Üç"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 4,
    //            RangeEnd = 4,
    //            Text = "Dört"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 5,
    //            RangeEnd = 5,
    //            Text = "Beş"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 6,
    //            RangeEnd = 6,
    //            Text = "Altı"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 7,
    //            RangeEnd = 7,
    //            Text = "Yedi"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 8,
    //            RangeEnd = 8,
    //            Text = "Sekiz"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 9,
    //            RangeEnd = 9,
    //            Text = "Dokuz"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 10,
    //            RangeEnd = 19,
    //            Text = "On"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 20,
    //            RangeEnd = 29,
    //            Text = "Yirmi"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 30,
    //            RangeEnd = 39,
    //            Text = "Otuz"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 40,
    //            RangeEnd = 49,
    //            Text = "Kırk"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 50,
    //            RangeEnd = 59,
    //            Text = "Elli"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 60,
    //            RangeEnd = 69,
    //            Text = "Atmış"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 70,
    //            RangeEnd = 79,
    //            Text = "Yetmiş"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 80,
    //            RangeEnd = 89,
    //            Text = "Seksen"
    //        });
    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 90,
    //            RangeEnd = 99,
    //            Text = "Doksan"
    //        });

    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 100,
    //            RangeEnd = 999,
    //            Text = "Yüz"
    //        });

    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = 1000,
    //            RangeEnd = 999999,
    //            Text = "Bin"
    //        });

    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = Convert.Toint32(Math.Pow(10, 6)),
    //            RangeEnd = Convert.Toint32(Math.Pow(10, 9)) - 1,
    //            Text = "Milyon"
    //        });

    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = Convert.Toint64(Math.Pow(10, 9)),
    //            RangeEnd = Convert.Toint64(Math.Pow(10, 12)) - 1,
    //            Text = "Milyar"
    //        });

    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = Convert.Toint64(Math.Pow(10, 12)),
    //            RangeEnd = Convert.Toint64(Math.Pow(10, 15)) - 1,
    //            Text = "Trilyon"
    //        });

    //        _moneyDefinition.Add(new MoneyDefiniton() {
    //            RangeStart = Convert.Toint64(Math.Pow(10, 15)),
    //            RangeEnd = Convert.Toint64(Math.Pow(10, 18)) - 1,
    //            Text = "Katrilyon"
    //        });

    //    }
       
    //   public static string ConvertMoneyToText(double money) {
    //        var result = "";

    //        var moneyPaths = money.Tostring("N0").Split('.');
    //        // gelen sayıyı formatlayıp 3 haneli olacak şekilde dizilere atıyorum. Örnek 9582141 sayısı için 9.582.141 formatında sokup ardın 3 elemanlı bir diziye dönüştürüyorum.

    //        for (var i = 0; i < moneyPaths.Length; i++) {
    //            var subText = MoneySubText(moneyPaths[i].Tostring()).Trim();
    //            var pow = money.Tostring("N0").Replace(".", "").Length - 1 - i * 3; // sayının ondalık kısmını belirliyoruz

    //            if (pow > 2) {
    //                var maintext = _moneyDefinition.FirstOrDefault(f => Math.Pow(10, pow) >= f.RangeStart && Math.Pow(10, pow) <= f.RangeEnd);
    //                // ondalık sayıya göre girilen sayıya denk gelen aralık bulunur. Böylelikle Bin, Milyon, Milyar.. gb hangi kısma denk geldiği belirlenir.

    //                if (maintext != null && !string.isNullOrEmpty(subText))
    //                    result = result.Trim() + " " + subText + " " + maintext.Text;
    //            }
    //            else // 1000 den küçük sayılar için subText kısmında hesaplama yaptığımız için direkt gelen değeri sonuca ekliyorum.
    //                result = result.Trim() + " " + subText;
    //        }

    //        result = result.Trim();

    //        return result;
    //    }
       
    //   public static string MoneySubText(string moneyText) {
    //        var result = "";
    //        var stepNo = 0;
    //        for (var i = moneyText.Length - 1; i >= 0; i--) {
    //            var step = (Math.Pow(10, stepNo));
    //            var number = Convert.Toint32(moneyText[i].Tostring()) * step;
    //            stepNo++;
    //            if (number == 0) continue;

    //            var numberText = _moneyDefinition.FirstOrDefault(f => number >= f.RangeStart && number <= f.RangeEnd);
    //            if (number < 199) {
    //                if (numberText != null) {
    //                    result = numberText.Text + " " + result;
    //                }
    //            }
    //            else {
    //                var firstNumberText = _moneyDefinition.FirstOrDefault(f => number / step >= f.RangeStart && number / step <= f.RangeEnd);
    //                var lastNumberText = _moneyDefinition.FirstOrDefault(f => step >= f.RangeStart && step <= f.RangeEnd);
    //                if (firstNumberText != null && lastNumberText != null) {
    //                    result = firstNumberText.Text + " " + lastNumberText.Text + " " + result;
    //                }

    //            }
    //        }
    //        return result;
    //    }

       
    public class MoneyTalks {
        public static string ParayiYaziyaCevir(string gelentutar) {
            decimal dectutar = Convert.ToDecimal(gelentutar);
            string strTutar = dectutar.ToString("F2").Replace('.', ',');    // Replace('.',',') ondalık ayraç ayracı           
            string lira = strTutar.Substring(0, strTutar.IndexOf(',')); //tutarın lira kısmı
            string kurus = strTutar.Substring(strTutar.IndexOf(',') + 1, 2);
            string yazi = "";
            string[] birler = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] onlar = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] binler = { "Katrilyon", "Trilyon", "Milyar", "Milyon", "Bin", "" }; //KATRİLYON'un önüne ekleme yapılarak artırabilir.
            int grupSayisi = 6;
            lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.
            string grupDegeri;

            for (int i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
                        {
                grupDegeri = "";
                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "Yüz"; //yüzler
                if (grupDegeri == "BirYüz") //biryüz düzeltiliyor.
                    grupDegeri = "Yüz";
                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar
                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler
                if (grupDegeri != "") //binler
                    grupDegeri += "" + binler[i / 3];
                if (grupDegeri == "BirBin") //birbin düzeltiliyor.
                    grupDegeri = "Bin";
                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += "TL";
            int yaziUzunlugu = yazi.Length;
            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];
            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];
            if (yazi.Length > yaziUzunlugu)
                yazi += "KR";
            else
                yazi += "";
            return yazi;
        }

    }
}

