using Business.Abstract;
using Core.Helpers.Result.Abstract;
using Core.Helpers.Result.Concrete;
using DataAccess.EF.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager(IOrderDal orderDal) : IOrderService
    {
        private readonly IOrderDal _orderDal = orderDal;

        public IResult Add(Order order)
        {
            _orderDal.Add(order);

            return new SuccessResult("Order added successfully");
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetAllOrders()
        {
            var orders = _orderDal.GetAll(o => o.IsDeleted == false);

            if (orders.Count != 0)
                return new SuccessDataResult<List<Order>>(orders, "Orders loaded");
            else
                return new ErrorDataResult<List<Order>>(orders, "List of orders is empty");
        }

        public IDataResult<Order> GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
