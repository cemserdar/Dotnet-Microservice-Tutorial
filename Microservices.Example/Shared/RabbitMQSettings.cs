using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    static public class RabbitMQSettings
    {
        public const string Stock_OrderCreatedEventQueue = "stock-order-created-event-queue";
        public const string Payment_StockReservedEventQueue = "payment-stock-reseved-event-queue";
        public const string Order_PaymentComplatedEventQueue = "order-payment-complated-event-queue";
        public const string Order_StockNotReservedEventQueue = "order-stock-not-reserved-event-queue";
        public const string Order_PaymentFailedEventQueue = "order-payment-failed-event-queue";
    }
}
