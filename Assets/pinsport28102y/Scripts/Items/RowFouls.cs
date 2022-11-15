using UnityEngine.UI;
using UnityEngine;

public class RowFouls : MonoBehaviour
{
    [SerializeField] Text _1;
    [SerializeField] Text _2;
    [SerializeField] Text _3;
    [SerializeField] Text _4;
    [SerializeField] Text _5;

    public void SetData(string[] words)
    {
        _1.text = words[0];
        _2.text = words[1];
        _3.text = words[2];
        _4.text = words[3];
        _5.text = words[4];
    }
}
