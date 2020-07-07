using Microsoft.WindowsAzure.Storage.Table;
using Serilog.Events;

namespace Serilog.Sinks.AzureTableStorage
{
    public interface IAzureTableStorageEntityFactory
    {
        DynamicTableEntity CreateEntityWithProperties(LogEvent logEvent);
    }
}
