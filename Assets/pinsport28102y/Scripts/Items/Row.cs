using UnityEngine.UI;
using UnityEngine;

public class Row : MonoBehaviour
{
    [SerializeField] Text _1;
    [SerializeField] Text _2;
    [SerializeField] Text _3;
    [SerializeField] Text _4;
    [SerializeField] Text _5;
    [SerializeField] Text _6;
    [SerializeField] Text _7;
    [SerializeField] Text _8;

    public void SetData(string[] words)
    {
        _1.text = words[0];
        _2.text = words[1];
        _3.text = words[2];
        _4.text = words[3];
        _5.text = words[4];
        _6.text = words[5];
        _7.text = words[6];
        _8.text = words[7];
    }
}
