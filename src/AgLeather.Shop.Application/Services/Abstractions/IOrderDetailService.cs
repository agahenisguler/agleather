using AgLeather.Shop.Application.Models.Dtos.OrderDetails;
using AgLeather.Shop.Application.Models.RequestModels.OrderDetails;
using AgLeather.Shop.Application.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Services.Abstractions
{
    public interface IOrderDetailService
    {
        #region Select
        Task<Result<List<OrderDetailDto>>> GetOrderDetailsByOrderId(GetOrderDetailsByOrderIdVM getByOrderIdVM);

        #endregion

        #region Insert, Update, Delete

        Task<Result<int>> CreateOrderDetail(CreateOrderDetailVM createOrderDetailVM);
        Task<Result<int>> DeleteOrderDetail(DeleteOrderDetailVM deleteOrderDetailVM);

        #endregion
    }
}
