using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.PrototypePattern
{
    // kopyalanmasını istediğimiz nesnedir
    class Araba:IClone
    {
        // nesnenin özellikleri
        public string isim { get; set; } 
        public string hiz { get; set; }
        public string numara { get; set; }
       
        public Araba(string isim,string hiz,string numara) // constructer 
        {
            this.isim = isim;
            this.hiz = hiz;
            this.numara = numara;
        }

        public IClone klonla() // klonlama işlemini miras aldığımız fonksiyon
        {
            return (IClone)MemberwiseClone(); // sistem tarafından kopyalamayı sağlayan kod 
        }
    }
}
