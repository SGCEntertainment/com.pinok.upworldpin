using UnityEngine;

public class ContentMaker : MonoBehaviour
{
    [SerializeField] bool enable;

    [Space(10)]
    [SerializeField, TextArea] string timeTable;
    [SerializeField, TextArea] string results;
    [SerializeField, TextArea] string table;
    [SerializeField, TextArea] string scorers;
    [SerializeField, TextArea] string fouls;

    [Space(10)]
    [SerializeField] TournirData activeTournir;

    private void OnValidate()
    {
        if(!enable)
        {
            return;
        }
        enable = false;

        //string[] rows = timeTable.Split('\n');
        //activeTournir.timetableDatas = new TimetableData[rows.Length];
        //for(int i = 0; i < rows.Length; i++)
        //{
        //    string[] words = rows[i].Split(';');
        //    activeTournir.timetableDatas[i] = new TimetableData()
        //    {
        //        leftCommandIcon = Resources.Load<Sprite>($"Icons/Uzbek/{words[0]}"),
        //        rightCommandIcon = Resources.Load<Sprite>($"Icons/Uzbek/{words[1]}"),
        //        leftCommandName = words[0],
        //        rightCommandName = words[1],
        //        timeTableDate = "02.11.2022",
        //    };
        //}

        //string[] rows = results.Split('\n');
        //activeTournir.resultDatas = new ResultData[rows.Length];
        //for (int i = 0; i < rows.Length; i++)
        //{
        //    string[] words = rows[i].Split(';');
        //    activeTournir.resultDatas[i] = new ResultData()
        //    {
        //        leftCommandIcon = Resources.Load<Sprite>($"Icons/Uzbek/{words[0]}"),
        //        rightCommandIcon = Resources.Load<Sprite>($"Icons/Uzbek/{words[2]}"),
        //        leftCommandName = words[0],
        //        rightCommandName = words[2],
        //        scoreString = words[1],
        //        timeTableDate = "02.03.2022|16:30",
        //    };
        //}

        //string[] rows = table.Split('\n');
        //activeTournir.tableData = new TableData()
        //{
        //    rows = new string[rows.Length]
        //};

        //for (int i = 0; i < rows.Length; i++)
        //{
        //    activeTournir.tableData.rows[i] = rows[i];
        //}

        string[] rowsScorers = scorers.Split('\n');
        ScorersData scorersData = new ScorersData()
        {
            rows = new string[rowsScorers.Length]
        };

        for (int i = 0; i < rowsScorers.Length; i++)
        {
            scorersData.rows[i] = rowsScorers[i];
        }

        string[] rowsFouls = fouls.Split('\n');
        FoulsData foulsData = new FoulsData()
        {
            rows = new string[rowsFouls.Length]
        };

        for (int i = 0; i < rowsFouls.Length; i++)
        {
            foulsData.rows[i] = rowsFouls[i];
        }

        activeTournir.statsData = new StatsData()
        {
            scorersData = scorersData,
            foulsData = foulsData
        };
    }
}
