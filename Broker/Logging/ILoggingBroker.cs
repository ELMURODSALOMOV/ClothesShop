using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Broker.Logging
{
    internal interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogError(string message);
        void LogError(Exception exception);
    }
}
