using MassTransit;
using MassTransit.Transports;
using Shared.Events;

namespace Payment.API.Consumers
{
    public class StockReservedEventConsumer : IConsumer<StockReservedEvent>
    {
        readonly IPublishEndpoint _publishEndpoint;

        public StockReservedEventConsumer(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        public Task Consume(ConsumeContext<StockReservedEvent> context)
        {


            //Ödeme İşlemleri

            if (true)
            {
                PaymentComplatedEvent paymentComplatedEvent = new()
                {
                    OrderId = context.Message.OrderId
                };
                //Başarılı
                _publishEndpoint.Publish(paymentComplatedEvent);

                Console.WriteLine("Ödeme Başarılı");
            }
            else
            {
                //Başarısız
                PaymentFailedEvent paymentFailedEvent = new() {
                    OrderId = context.Message.OrderId,
                    Message = "Bakiye Yetersiz"
                };
                Console.WriteLine("Ödeme Başarısız");
            }


            return Task.CompletedTask;
        }
    }
}
