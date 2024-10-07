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
    public class RemoveOrderDetailCommandHandler
    {
        private readonly IRepostory<OrderDetail> _repostory;

        public RemoveOrderDetailCommandHandler(IRepostory<OrderDetail> repostory)
        {
            _repostory = repostory;
        }
        public async Task Handle(RemoveOrderDetailCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.Id);
            await _repostory.DeleteAsync(values);
        }
    }
}
