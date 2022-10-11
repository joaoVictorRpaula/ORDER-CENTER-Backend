using Microsoft.AspNetCore.SignalR;
using ORDER_CENTER_API.Data;
using ORDER_CENTER_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ORDER_CENTER_API.Services
{
    public class TempOrdersService
    {
        private readonly AppDbContext _db;

        public TempOrdersService(AppDbContext db)
        {
            _db = db;
        }

        public List<TempOrders> AddTempOrders(List<TempOrders> tempOrders)
        {
            if(tempOrders == null)
            {
                return null;
            }
            _db.TempOrders.AddRange(tempOrders);
            _db.SaveChanges();

            return tempOrders;
        }

        public TempOrders RemoveTempOrder(int tempOrderId)
        {
            TempOrders tempOrder = _db.TempOrders.FirstOrDefault(tO => tO.Id == tempOrderId);
            if(tempOrder == null)
            {
                return null;
            }

            _db.TempOrders.Remove(tempOrder);
            _db.SaveChanges();
            return tempOrder;
        }

        public List<TempOrders> GetAllTempOrders()
        {
            List<TempOrders> tempOrders = _db.TempOrders.ToList();

            if(tempOrders == null)
            {
                return null;
            }

            return tempOrders;
        }

    }
}
