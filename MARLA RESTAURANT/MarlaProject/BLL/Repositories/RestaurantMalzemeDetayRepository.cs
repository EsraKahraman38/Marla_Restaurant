using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class RestaurantMalzemeDetayRepository :IRepository<RestaurantMalzemeDetay>
    {
        MarlaRestaurantEntities db = new MarlaRestaurantEntities();

        public void Delete(int itemId)
        {
            RestaurantMalzemeDetay id = db.RestaurantMalzemeDetay.Find(itemId);
            db.RestaurantMalzemeDetay.Remove(id);
            db.SaveChanges();
        }

        public List<RestaurantMalzemeDetay> GetAll()
        {
            return db.RestaurantMalzemeDetay.ToList();
        }

        public RestaurantMalzemeDetay GetByID(int id)
        {
            return db.RestaurantMalzemeDetay.Find(id);
        }

        public void Insert(RestaurantMalzemeDetay item)
        {
            db.RestaurantMalzemeDetay.Add(item);
            db.SaveChanges();
        }

        public void Update(RestaurantMalzemeDetay item)
        {
            RestaurantMalzemeDetay gelen = db.RestaurantMalzemeDetay.Find(item.RestaurantMalzemeDetayID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
