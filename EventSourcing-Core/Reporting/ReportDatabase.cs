
namespace EventSourcing_Core.Reporting
{
    public class ReportDatabase : IReportDatabase
    {
        static List<DiaryItemDto> items = new List<DiaryItemDto>();
        public List<DiaryItemDto> GetItems()
        {
            return items;
        }
    }
}
