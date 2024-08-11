
namespace EventSourcing_Core.Reporting
{
    public interface IReportDatabase
    {
        List<DiaryItemDto> GetItems();
    }
}
