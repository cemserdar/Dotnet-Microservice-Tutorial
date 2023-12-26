using MassTransit;
using Microsoft.EntityFrameworkCore;
using Order.API.Models;
using Shared.Events;

namespace Order.API.Consumer
{
    public class PaymentComplatedEventConsumer : IConsumer<PaymentComplatedEvent>
    {
        readonly OrderAPIDbContext _orderAPIDbContext;

        public PaymentComplatedEventConsumer(OrderAPIDbContext orderAPIDbContext)
        {
            _orderAPIDbContext = orderAPIDbContext;
        }

        public async Task Consume(ConsumeContext<PaymentComplatedEvent> context)
        {
           Order.API.Models.Entities.Order order = await _orderAPIDbContext.Orders.FirstOrDefaultAsync(o => o.OrderId == context.Message.OrderId);

            order.OrderStatu = Models.Enums.OrderStatus.Complate;
            await _orderAPIDbContext.SaveChangesAsync();
        }
    }
}
