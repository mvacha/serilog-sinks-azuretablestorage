using Microsoft.WindowsAzure.Storage.Table;
using Serilog.Events;

namespace Serilog.Sinks.AzureTableStorage
{
    public interface IAzurePropertyFormatter
    {
        EntityProperty ToEntityProperty(LogEventPropertyValue value, string format);
    }
}
