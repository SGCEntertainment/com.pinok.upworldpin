using UnityEngine;

public class ScorersItem : MonoBehaviour
{
    public void SetData(ScorersData scorersData)
    {
        RowScorers row = Resources.Load<RowScorers>("Items/rowScorers");
        foreach (string s in scorersData.rows)
        {
            string[] words = s.Split(';');
            Instantiate(row, transform).SetData(words);
        }
    }
}
