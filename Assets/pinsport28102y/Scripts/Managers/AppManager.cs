using UnityEngine;

public class AppManager : MonoBehaviour
{
    public static AppManager Instance
    {
        get => FindObjectOfType<AppManager>();
    }

    private TimetableIItem TimeTableItem { get; set; }
    private ResultItem ResultItem { get; set; }
    private TableItem TableItem { get; set; }
    private StatsItem StatsItem { get; set; }
    private Transform ParentContent { get; set; }

    public TournirData ActiveTournir;

    private void Awake() => CacheComponents();

    private void CacheComponents()
    {
        TimeTableItem = Resources.Load<TimetableIItem>("Items/timetableIItem");
        ResultItem = Resources.Load<ResultItem>("Items/resultItem");
        TableItem = Resources.Load<TableItem>("Items/tableItem");
        StatsItem = Resources.Load<StatsItem>("Items/statsItem");

        ParentContent = GameObject.Find("ParentContent").transform;
    }

    private void ClearOldElements()
    {
        foreach (Transform t in ParentContent)
        {
            Destroy(t.gameObject);
        }

        ParentContent.DetachChildren();
    }

    public void SetActiveTournir(TournirData _tournirData)
    {
        ActiveTournir = _tournirData;
        SetActivePage(0);
    }

    public void SetActivePage(int pageIndex)
    {
        ClearOldElements();
        Debug.Log(TimeTableItem.name);

        switch(pageIndex)
        {
            case 0:

                foreach(TimetableData timetableData in ActiveTournir.timetableDatas)
                {
                    Instantiate(TimeTableItem, ParentContent).SetData(timetableData);
                }break;

            case 1: break;
            case 2: break;
            case 3: break;
        }
    }
}
