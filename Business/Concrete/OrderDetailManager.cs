using Business.Abstract;
using Core.Helpers.Result.Abstract;
using Core.Helpers.Result.Concrete;
using DataAccess.EF.Abstract;
using DataAccess.Migrations;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderDetailManager(IOrderDetailDal orderDetailDal) : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal = orderDetailDal;

        public IResult Add(OrderDetail orderDetail)
        {
            _orderDetailDal.Add(orderDetail);

            return new SuccessResult("Order Details added successfully");
        }

        public IDataResult<List<OrderDetailDto>> GetAllOrderDetails()
        {
            var orderDetails = _orderDetailDal.GetAllOrderDetails();

            if (orderDetails.Count != 0)
                return new SuccessDataResult<List<OrderDetailDto>>(orderDetails, "OrderDetails loaded");
            else
                return new ErrorDataResult<List<OrderDetailDto>>(orderDetails, "List of orderDetails is empty");
        }
    }
}
