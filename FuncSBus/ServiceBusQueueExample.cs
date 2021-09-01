using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
//Create SB->Queue : https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-quickstart-portal
//Receive Message -> https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-dotnet-get-started-with-queues
//Function binding, SB Trigger : https://docs.microsoft.com/en-us/azure/azure-functions/functions-bindings-service-bus-trigger?tabs=csharp
//https://www.programmingwithwolfgang.com/azure-functions-process-queue-messages/
namespace FuncSBus
{
    public static class ServiceBusQueueExample
    {
        [FunctionName("ServiceBusQueueExample")]
        public static void Run([ServiceBusTrigger("queue-mrbab", Connection = "MyCon")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
