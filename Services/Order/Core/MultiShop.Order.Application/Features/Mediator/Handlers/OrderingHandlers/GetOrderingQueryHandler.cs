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
    public class GetOrderingQueryHandler : IRequestHandler<GetOrderingQuery, List<GetOrderingQueryResult>>
    {
        private readonly IRepostory<Ordering> _repostory;

        public GetOrderingQueryHandler(IRepostory<Ordering> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetOrderingQueryResult>> Handle(GetOrderingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetOrderingQueryResult
            {
                OrderingId=x.OrderingId,
                OrderDate=x.OrderDate,
                TotalPrice=x.TotalPrice,
                UserId=x.UserId
            }).ToList();
        }
    }
}
