using UnityEngine;

public class TableItem : MonoBehaviour
{
    public void SetData(TableData tableData)
    {
        Row row = Resources.Load<Row>("Items/row");
        foreach(string s in tableData.rows)
        {
            string[] words = s.Split(';');
            Instantiate(row, transform).SetData(words);
        }
    }
}
