using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

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


    private GameObject HorizontalNavigation { get; set; }
    private GameObject GameActivity { get; set; }


    private int photoId = 0;
    private Texture2D[] photos;


    private TournirData ActiveTournir;

    private void Awake() => CacheComponents();

    private void Start()
    {
        SetActiveTournir(GameObject.Find("meniuItem (1)").GetComponent<NavTopBtn>().tournirData);
    }

    private void CacheComponents()
    {
        TimeTableItem = Resources.Load<TimetableIItem>("Items/timetableIItem");
        ResultItem = Resources.Load<ResultItem>("Items/resultItem");
        TableItem = Resources.Load<TableItem>("Items/tableItem");
        StatsItem = Resources.Load<StatsItem>("Items/statsItem");
        ParentContent = GameObject.Find("ParentContent").transform;

        HorizontalNavigation = GameObject.Find("horizontalNavigationBottom");
        GameActivity = GameObject.Find("gameActivity");

        photos = new Texture2D[3];
        photos[0] = Resources.Load<Texture2D>("Photos/Com_1");
        photos[1] = Resources.Load<Texture2D>("Photos/Com_2");
        photos[2] = Resources.Load<Texture2D>("Photos/Com_3");
    }

    private void ClearOldElements()
    {
        foreach (Transform t in ParentContent)
        {
            Destroy(t.gameObject);
        }

        ParentContent.DetachChildren();
    }

    public void SetGame()
    {
        NavTopBtn[] navTopBtns = FindObjectsOfType<NavTopBtn>();
        foreach (NavTopBtn nt in navTopBtns)
        {
            nt.SetActive(false);
        }

        HorizontalNavigation.SetActive(false);
        GameActivity.SetActive(true);
    }

    public void SetActiveTournir(TournirData _tournirData)
    {
        NavTopBtn[] navTopBtns = FindObjectsOfType<NavTopBtn>();
        foreach (NavTopBtn nt in navTopBtns)
        {
            nt.SetActive(nt.tournirData == _tournirData);
        }

        HorizontalNavigation.SetActive(true);
        GameActivity.SetActive(false);

        ActiveTournir = _tournirData;
        SetActivePage(0);
    }

    public void SetActivePage(int pageIndex)
    {
        NavBottomBtn[] navBottomBtns = FindObjectsOfType<NavBottomBtn>();
        foreach(NavBottomBtn nb in navBottomBtns)
        {
            nb.SetActive(nb.transform.GetSiblingIndex() == pageIndex);
        }

        ClearOldElements();

        switch(pageIndex)
        {
            case 0:

                foreach(TimetableData timetableData in ActiveTournir.timetableDatas)
                {
                    if(photoId >= photos.Length)
                    {
                        photoId = 0;
                    }

                    Instantiate(TimeTableItem, ParentContent).SetData(timetableData, photos[photoId]);
                    photoId++;
                }break;

            case 1:

                foreach (ResultData resultData in ActiveTournir.resultDatas)
                {
                    if (photoId >= photos.Length)
                    {
                        photoId = 0;
                    }

                    Instantiate(ResultItem, ParentContent).SetData(resultData, photos[photoId]);
                    photoId++;
                }
                break;

            case 2:

                Instantiate(TableItem, ParentContent).SetData(ActiveTournir.tableData);
                break;

            case 3:

                Instantiate(StatsItem, ParentContent).SetData(ActiveTournir.statsData);
                break;
        }

        ParentContent.GetComponentInParent<ScrollRect>().verticalNormalizedPosition = 1;
        Canvas.ForceUpdateCanvases();
    }
}
