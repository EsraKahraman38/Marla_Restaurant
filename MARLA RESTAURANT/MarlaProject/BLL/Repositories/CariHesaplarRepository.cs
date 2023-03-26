using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class CariHesaplarRepository:IRepository<CariHesaplar>
    {
        MarlaRestaurantEntities db = new MarlaRestaurantEntities();

        public void Delete(int itemId)
        {
            CariHesaplar id = db.CariHesaplar.Find(itemId);
            db.CariHesaplar.Remove(id);
            db.SaveChanges();
        }

        public List<CariHesaplar> GetAll()
        {
            return db.CariHesaplar.ToList();
        }

        public CariHesaplar GetByID(int id)
        {
            return db.CariHesaplar.Find(id);
        }

        public void Insert(CariHesaplar item)
        {
            db.CariHesaplar.Add(item);
            db.SaveChanges();
        }

        public void Update(CariHesaplar item)
        {
            CariHesaplar gelen = db.CariHesaplar.Find(item.CariHesapID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
