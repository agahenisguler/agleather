﻿using AgLeather.Shop.Application.Behaviors;
using AgLeather.Shop.Application.Exceptions;
using AgLeather.Shop.Application.Models.Dtos.OrderDetails;
using AgLeather.Shop.Application.Models.RequestModels.OrderDetails;
using AgLeather.Shop.Application.Services.Abstractions;
using AgLeather.Shop.Application.Validators.OrderDetails;
using AgLeather.Shop.Application.Wrapper;
using AgLeather.Shop.Domain.Entities;
using AgLeather.Shop.Domain.UWork;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace AgLeather.Shop.Application.Services.Implementation
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IUnitWork _unitWork;
        private readonly IMapper _mapper;

        public OrderDetailService(IUnitWork unitWork, IMapper mapper)
        {
            _unitWork = unitWork;
            _mapper = mapper;
        }

        [ValidationBehavior(typeof(GetOrderDetailsByOrderIdValidator))]
        public async Task<Result<List<OrderDetailDto>>> GetOrderDetailsByOrderId(GetOrderDetailsByOrderIdVM getByOrderIdVM)
        {
            var result = new Result<List<OrderDetailDto>>();

            var orderDetailEntities = await _unitWork.GetRepository<ProductImage>().GetByFilterAsync(x => x.ProductId == getByOrderIdVM.OrderId);
            var productImageDtos = await orderDetailEntities.ProjectTo<OrderDetailDto>(_mapper.ConfigurationProvider).ToListAsync();

            result.Data = productImageDtos;
            return result;
        }


        [ValidationBehavior(typeof(CreateOrderDetailValidator))]
        public async Task<Result<int>> CreateOrderDetail(CreateOrderDetailVM createOrderDetailVM)
        {
            var result = new Result<int>();

            var orderExists = await _unitWork.GetRepository<OrderDetail>().AnyAsync(x => x.Id == createOrderDetailVM.OrderId);
            if (!orderExists)
            {
                throw new NotFoundException($"{createOrderDetailVM.OrderId} numaralı sipariş bulunamadı.");
            }

            var productExists = await _unitWork.GetRepository<OrderDetail>().AnyAsync(x => x.ProductId == createOrderDetailVM.ProductId);
            if (productExists)
            {
                throw new NotFoundException($"{createOrderDetailVM.OrderId} numaralı sipariş için {createOrderDetailVM.ProductId} numaralı ürün daha önce eklenmiştir.");
            }

            var orderDetailEntity = _mapper.Map<OrderDetail>(createOrderDetailVM);

            _unitWork.GetRepository<OrderDetail>().Add(orderDetailEntity);
            await _unitWork.CommitAsync();

            result.Data = orderDetailEntity.Id;
            return result;
        }


        [ValidationBehavior(typeof(DeleteOrderDetailValidator))]
        public async Task<Result<int>> DeleteOrderDetail(DeleteOrderDetailVM deleteOrderDetailVM)
        {
            var result = new Result<int>();

            var existsOrderDetail = await _unitWork.GetRepository<OrderDetail>().GetById(deleteOrderDetailVM.OrderDetailId);
            if (existsOrderDetail is null)
            {
                throw new NotFoundException($"{deleteOrderDetailVM.OrderDetailId} numaralı ürün sipariş detayı bulunamadı.");
            }

            _unitWork.GetRepository<OrderDetail>().Delete(existsOrderDetail);
            await _unitWork.CommitAsync();

            result.Data = existsOrderDetail.Id;
            return result;
        }
    }
}
