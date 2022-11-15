using UnityEngine;

public class AppManager : MonoBehaviour
{
    private TimetableIItem TimeTableItem { get; set; }
    private ResultItem ResultItem { get; set; }
    private TableItem TableItem { get; set; }
    private StatsItem StatsItem { get; set; }
    private Transform ParentContent { get; set; }

    private void Awake() => CacheComponents();

    private void CacheComponents()
    {
        TimeTableItem = Resources.Load<TimetableIItem>("Items/timetableIItem");
        ResultItem = Resources.Load<ResultItem>("Items/resultItem");
        TableItem = Resources.Load<TableItem>("Items/tableItem");
        StatsItem = Resources.Load<StatsItem>("Items/statsItem");

        ParentContent = GameObject.Find("ParentContent").transform;
    }
}
