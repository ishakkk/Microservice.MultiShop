using MultiShop.Order.Application.Features.CQRS.Results.OrderDetailResult;
using MultiShop.Order.Application.Interfaces;
using MultShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailQueryHandler
    {
        private readonly IRepostory<OrderDetail> _repostory;

        public GetOrderDetailQueryHandler(IRepostory<OrderDetail> repostory)
        {
            _repostory = repostory;
        }
        public async Task<List<GetOrderDetailQueryResult>> Handle()
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetOrderDetailQueryResult
            {
                OrderDetailId=x.OrderDetailId,
                OrderingId=x.OrderingId,
                ProductAmount=x.ProductAmount,
                ProductId= x.ProductId,
                ProductName = x.ProductName,
                ProductPrice= x.ProductPrice,
                ProductTotalPrice = x.ProductTotalPrice
            }).ToList();
        }
    }
}
