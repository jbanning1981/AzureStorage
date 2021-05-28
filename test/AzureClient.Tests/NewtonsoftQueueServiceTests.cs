using AzureClient.Core.Interfaces;
using AzureClient.Core.Models;
using AzureClient.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AzureClient.Tests
{
    [Trait("Category", "Integration_Local")]
    public class NewtonsoftQueueServiceTests : BaseQueueServiceTest
    {


        public NewtonsoftQueueServiceTests()
        {
            _queueConfig = GetConfiguration();
            _queueService = new QueueService(_queueConfig);
            _queueName = "newtonsoft-test-queue";
            _queueClient = GetQueueClient();
        }

    }
}