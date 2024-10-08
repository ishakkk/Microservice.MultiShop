using MediatR;
using MultiShop.Order.Application.Features.Mediator.Commands.OrderingCommands;
using MultiShop.Order.Application.Interfaces;
using MultShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
    public class CreateOrderingCommandHandler : IRequestHandler<CreateOrderingCommand>
    {
        private readonly IRepostory<Ordering> _repostory;

        public CreateOrderingCommandHandler(IRepostory<Ordering> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(CreateOrderingCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new Ordering
            {
                OrderDate=request.OrderDate,
                UserId=request.UserId,
                TotalPrice=request.TotalPrice
            });
        }
    }
}
