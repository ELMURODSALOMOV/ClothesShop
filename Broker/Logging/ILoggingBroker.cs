//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

namespace ClothesShop.Broker.Logging
{
    internal interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogInfo(string message);
        void LogError(string message);
        void LogError(Exception exception);
    }
}
