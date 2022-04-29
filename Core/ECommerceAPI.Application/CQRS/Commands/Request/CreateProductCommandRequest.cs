using ECommerceAPI.Application.CQRS.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.CQRS.Commands.Request
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {

        public string Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
    }
}
