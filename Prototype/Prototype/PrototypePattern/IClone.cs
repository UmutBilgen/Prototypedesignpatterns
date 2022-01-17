using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.PrototypePattern
{

    // yeni nesnelerin kopyalanmasını sağlayan ve bu işlem için klonla fonksiyonunu barındıran sınıftır
    interface IClone
    {
        IClone klonla();
    }
}
