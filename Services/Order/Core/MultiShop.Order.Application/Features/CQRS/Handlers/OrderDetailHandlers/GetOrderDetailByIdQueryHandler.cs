
using MultiShop.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
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
    public class GetOrderDetailByIdQueryHandler
    {
        private readonly IRepostory<OrderDetail> _repostory;

        public GetOrderDetailByIdQueryHandler(IRepostory<OrderDetail> repostory)
        {
            _repostory = repostory;
        }
        public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery query)
        {
            var values = await _repostory.GetByIdAsync(query.Id);
            return new GetOrderDetailByIdQueryResult
            {
               OrderDetailId = values.OrderDetailId,
               OrderingId=values.OrderingId,
               ProductAmount=values.ProductAmount,
               ProductId = values.ProductId,
               ProductName = values.ProductName,
               ProductPrice=values.ProductPrice,
               ProductTotalPrice = values.ProductTotalPrice
            };
        }
    }
}
