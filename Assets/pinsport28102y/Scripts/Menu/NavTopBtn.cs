using UnityEngine.UI;
using UnityEngine;

public class NavTopBtn : MonoBehaviour
{
    public TournirData tournirData;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            AppManager.Instance.SetActiveTournir(tournirData);
        });
    }
}
