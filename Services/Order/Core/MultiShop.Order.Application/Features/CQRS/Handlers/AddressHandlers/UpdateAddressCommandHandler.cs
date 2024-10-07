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
    public class UpdateAddressCommandHandler
    {
        private readonly IRepostory<Address> _repostory;

        public UpdateAddressCommandHandler(IRepostory<Address> repostory)
        {
            _repostory = repostory;
        }
        public async Task Handle(UpdateAddressCommand command)
        {
            var values= await _repostory.GetByIdAsync(command.AddressId);
            values.Detail=command.Detail;
            values.District=command.District;
            values.City=command.City;
            values.UserId=command.UserId;
            await _repostory.UpdateAsync(values);
        }
    }
}
