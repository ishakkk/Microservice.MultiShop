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
    public class UpdateOrderDetailCommandHandler
    {
        private readonly IRepostory<OrderDetail> _repostory;

        public UpdateOrderDetailCommandHandler(IRepostory<OrderDetail> repostory)
        {
            _repostory = repostory;
        }
        public async Task Handle(UpdateOrderDetailCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.OrderDetailId);
            values.OrderingId = command.OrderingId;
            
            values.ProductId= command.ProductId;
            values.ProductName= command.ProductName;
            values.ProductPrice= command.ProductPrice;
            values.ProductAmount= command.ProductAmount;
            values.ProductTotalPrice= command.ProductTotalPrice;
            await _repostory.UpdateAsync(values);
        }
    }
}
