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
    public class CreateAddressCommandHandler
    {
        private readonly IRepostory<Address> _repostory;

        public CreateAddressCommandHandler(IRepostory<Address> repostory)
        {
            _repostory = repostory;
        }
        public async Task Handle(CreateAddressCommand createAddressCommand) 
        {
            await _repostory.CreateAsync(new Address
            {
                City=createAddressCommand.City,
                Detail=createAddressCommand.Detail,
                District=createAddressCommand.District,
                UserId=createAddressCommand.UserId
            });
        }
    }
}
