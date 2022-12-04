using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint (Generic tipine uygulanan veri tipi sınırlaması, böylece T yerine herhangi bir veri tipi girilemeyecek)
    //class : referans tipinde 
    //IEntity : IEntity veya IEntity tarafından referansı tutulan objeler
    //new() : new'lenebilen objeler. Boylece IEntity'de veri tipi olarak veremicez sadece IEntitynin tuttuğu concrete classları verebileceğiz.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //GetAll(p => p.CategoryId == 2) ifadesini vermemizi sağlayan expression ifadesidir.O yüzden bide kendi oluşturduğumuz
        //metotlarımızda bu fonksiyonelliği kullanmak istersek alttaki ifadeyi belirtmemiz gerekir.

        List<T> GetAll(Expression<Func<T, bool>> filter = null);  //filter=null filtre verme zorunluluğu olmadığını söyler
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
