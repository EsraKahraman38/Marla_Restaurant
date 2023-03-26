using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UrunMalzemeDetayRepository : IRepository<UrunMalzemeDetay>
    {
        MarlaRestaurantEntities db = new MarlaRestaurantEntities();
        public void Delete(int itemId)
        {
            UrunMalzemeDetay id = db.UrunMalzemeDetay.Find(itemId);
            db.UrunMalzemeDetay.Remove(id);
            db.SaveChanges();
        }

        public List<UrunMalzemeDetay> GetAll()
        {
            return db.UrunMalzemeDetay.ToList();
        }

        public UrunMalzemeDetay GetByID(int id)
        {
            return db.UrunMalzemeDetay.Find(id);
        }

        public void Insert(UrunMalzemeDetay item)
        {
            db.UrunMalzemeDetay.Add(item);
            db.SaveChanges();
        }

        public void Update(UrunMalzemeDetay item)
        {
            UrunMalzemeDetay gelen = db.UrunMalzemeDetay.Find(item.UrunMalzemeID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
