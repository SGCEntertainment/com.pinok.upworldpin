using UnityEngine;

public class FoulsItem : MonoBehaviour
{
    public void SetData(FoulsData foulsData)
    {
        RowFouls row = Resources.Load<RowFouls>("Items/rowFouls");
        foreach (string s in foulsData.rows)
        {
            string[] words = s.Split(';');
            Instantiate(row, transform).SetData(words);
        }
    }
}
