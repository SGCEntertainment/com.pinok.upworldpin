using UnityEngine;

public class StatsItem : MonoBehaviour
{
    public void SetData(StatsData statsData)
    {
        ScorersItem scorersItem = Resources.Load<ScorersItem>("Items/scorersItem");
        FoulsItem foulsItem = Resources.Load<FoulsItem>("Items/foulsItem");

        Instantiate(scorersItem, transform).SetData(statsData.scorersData);
        Instantiate(foulsItem, transform).SetData(statsData.foulsData);
    }
}
