using ORDER_CENTER_API.Data;
using ORDER_CENTER_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ORDER_CENTER_API.Services
{
    public class FoodsService
    {
        private readonly AppDbContext _db;

        public FoodsService(AppDbContext db)
        {
            _db = db;
        }

        public List<Foods> GetAllFoods()
        {
            List<Foods> foods = _db.Foods.ToList();

            if(foods == null)
            {
                return null;
            }

            return foods;
        }
    }
}
