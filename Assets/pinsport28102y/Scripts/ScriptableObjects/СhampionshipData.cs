using UnityEngine;

[CreateAssetMenu]
public class СhampionshipData : ScriptableObject
{
    public string championshipName;

    [Space(10)]
    public TimetableData[] timetableDatas;

    [Space(10)]
    public ResultItem[] resultItems;

    [Space(10)]
    public TableData tableData;

    [Space(10)]
    public StatsData statsData;
}
