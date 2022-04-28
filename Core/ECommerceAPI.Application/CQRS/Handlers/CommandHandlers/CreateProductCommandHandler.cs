using ECommerceAPI.Application.CQRS.Commands.Request;
using ECommerceAPI.Application.CQRS.Commands.Response;
using ECommerceAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler:IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        IProductWriteRepository _repository;

        public CreateProductCommandHandler(IProductWriteRepository _repository)
        {
            this._repository = _repository;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            await _repository.AddAsync(new()
            {
                Id = id,
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock,
                IsDeleted = false
            });
            await _repository.SaveAsync();
            return new CreateProductCommandResponse
            {
                IsSuccess = true,
            };
        }
    }
}
