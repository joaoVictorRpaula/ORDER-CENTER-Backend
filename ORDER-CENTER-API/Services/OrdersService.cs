using ORDER_CENTER_API.Data;
using ORDER_CENTER_API.Models;

namespace ORDER_CENTER_API.Services
{
    public class OrdersService
    {
        private readonly AppDbContext _db;

        public OrdersService(AppDbContext db)
        {
            _db= db; 
        }

        public Orders AddNewOrder(Orders order)
        {
            if (order == null)
            {
                return null;
            }

            _db.Orders.Add(order);
            _db.SaveChanges();

            return order;
        }

    }
}
