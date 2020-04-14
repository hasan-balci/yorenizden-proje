using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mağaza_yeni.model
{
    class Urun
    {
        public string resim { get; set; }
        public string isim { get; set; }
        public string stokBilgisi { get; set; }
        public string fiyat { get; set; }

        public Urun(string isim, string stokBilgisi, string fiyat, string resim)
        {
            this.isim = isim;
            this.stokBilgisi = stokBilgisi;
            this.fiyat = fiyat;
            this.resim = resim;
        }
    }
}
