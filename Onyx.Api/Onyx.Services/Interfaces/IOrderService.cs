using Onyx.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Services.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrderAsync(CreateOrderDto orderDto);
    }
}
