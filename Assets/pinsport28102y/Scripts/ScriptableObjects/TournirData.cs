using UnityEngine;

[CreateAssetMenu]
public class TournirData : ScriptableObject
{
    [Space(10)]
    public TimetableData[] timetableDatas;

    [Space(10)]
    public ResultData[] resultDatas;

    [Space(10)]
    public TableData tableData;

    [Space(10)]
    public StatsData statsData;
}
