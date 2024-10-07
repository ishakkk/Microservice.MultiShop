using MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Interfaces;
using MultShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class CreateOrderDetailCommandHandler
    {
        private readonly IRepostory<OrderDetail> _repostory;

        public CreateOrderDetailCommandHandler(IRepostory<OrderDetail> repostory)
        {
            _repostory = repostory;
        }
        public async Task Handle(CreateOrderDetailCommand command)
        {
            await _repostory.CreateAsync(new OrderDetail() 
            { 
               ProductAmount=command.ProductAmount,
               OrderingId=command.OrderingId,
               ProductId=command.ProductId,
               ProductName=command.ProductName,
               ProductPrice=command.ProductPrice,
               ProductTotalPrice=command.ProductTotalPrice
            
            });
        }
    }
}
