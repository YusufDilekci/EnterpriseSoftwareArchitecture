using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    //***Core katmanı diğer katmanları referans almaz.Çünkü birçok projede bu katman kullanılacağı için hiçbir projeye bağımlı değildir. 
    //IEntity'yi implement eden bir class veritabanı tablosudur.
    public interface IEntity
    {
    }
}
