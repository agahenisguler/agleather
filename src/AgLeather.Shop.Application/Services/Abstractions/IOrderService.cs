using AgLeather.Shop.Application.Models.Dtos.Orders;
using AgLeather.Shop.Application.Models.RequestModels.Orders;
using AgLeather.Shop.Application.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Services.Abstractions
{
    public interface IOrderService
    {
        #region Select
        Task<Result<List<OrderDto>>> GetOrdersByCustomer(GetOrdersByCustomerVM getOrdersByCustomerVM);

        #endregion

        #region Insert, Update, Delete
        Task<Result<int>> CreateOrder(CreateOrderVM createOrderVM);
        Task<Result<int>> UpdateOrder(UpdateOrderVM updateOrderVM);
        Task<Result<int>> DeleteOrder(DeleteOrderVM deleteOrderVM);
        #endregion
    }
}
