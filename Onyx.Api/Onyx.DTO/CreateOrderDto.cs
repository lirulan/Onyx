using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.DTO
{
    public class CreateOrderDto
    {
        public string CustomerName { get; set; }   
        public DateTime OrderDate { get; set; }    

        public List<OrderItemDto> Items { get; set; } = new List<OrderItemDto>(); 
    }
}
