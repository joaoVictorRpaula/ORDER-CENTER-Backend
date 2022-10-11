using Microsoft.AspNetCore.SignalR;
using ORDER_CENTER_API.Data;
using ORDER_CENTER_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ORDER_CENTER_API.Services
{
    public class Orders_ItensService
    {
        private readonly AppDbContext _db;
        public Orders_ItensService(AppDbContext db)
        {
            _db = db;
        }

        public List<Orders_Itens> GetOrders_Itens()
        {
            List<Orders_Itens> orders_Itens = _db.Orders_Itens.ToList();

            if(orders_Itens == null)
            {
                return null;
            }

            return orders_Itens;

        }

        public List<Orders_Itens> GetOrders_ItensByOrderId(int orderId)
        {
            List<Orders_Itens> orders_Itens = _db.Orders_Itens.Where(oI => oI.OrderId == orderId).ToList();

            if (orders_Itens == null)
            {
                return null;
            }

            return orders_Itens;

        }

        public List<Orders_Itens> AddOrders_Itens(List<Orders_Itens> orders_Itens)
        {
            if(orders_Itens == null)
            {
                return null;
            }

            _db.Orders_Itens.AddRange(orders_Itens);
            _db.SaveChanges();

            return orders_Itens;
        }

    }
}
