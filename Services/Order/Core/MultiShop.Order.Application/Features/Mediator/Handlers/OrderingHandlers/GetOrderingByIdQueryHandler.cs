using MediatR;
using MultiShop.Order.Application.Features.Mediator.Queries.OrderingQueries;
using MultiShop.Order.Application.Features.Mediator.Results.OrderingResults;
using MultiShop.Order.Application.Interfaces;
using MultShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
    public class GetOrderingByIdQueryHandler : IRequestHandler<GetOrderingByIdQuery, GetOrderingByIdQueryResult>
    {
        private readonly IRepostory<Ordering> _repostory;

        public GetOrderingByIdQueryHandler(IRepostory<Ordering> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetOrderingByIdQueryResult> Handle(GetOrderingByIdQuery request, CancellationToken cancellationToken)
        {
            var values= await _repostory.GetByIdAsync(request.Id);
            return new GetOrderingByIdQueryResult
            {
                OrderDate=values.OrderDate,
                OrderingId=values.OrderingId,
                TotalPrice=values.TotalPrice,
                UserId = values.UserId
            };
        }
    }
}
