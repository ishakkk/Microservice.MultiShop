using MediatR;
using MultiShop.Order.Application.Interfaces;
using MultShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.Mediator.Commands.OrderingCommands
{
    public class UpdateOrderingCommandHandler : IRequestHandler<UpdateOrderingCommand>
    {
        private readonly IRepostory<Ordering> _repostory;

        public UpdateOrderingCommandHandler(IRepostory<Ordering> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(UpdateOrderingCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.OrderingId);
            values.OrderDate = request.OrderDate;
            values.UserId = request.UserId;
            values.TotalPrice= request.TotalPrice;
            await _repostory.UpdateAsync(values);
        }
    }
}
