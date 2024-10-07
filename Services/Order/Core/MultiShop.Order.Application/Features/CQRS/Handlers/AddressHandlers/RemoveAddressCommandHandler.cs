using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class RemoveAddressCommandHandler
    {
        private readonly IRepostory<Address> _repostory;

        public RemoveAddressCommandHandler(IRepostory<Address> repostory)
        {
            _repostory = repostory;
        }
        public async Task Handle(RemoveAddressCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.Id);
            await _repostory.DeleteAsync(values);
        }
    }
}
