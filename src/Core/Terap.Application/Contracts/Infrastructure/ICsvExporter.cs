using Terap.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;

namespace Terap.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
