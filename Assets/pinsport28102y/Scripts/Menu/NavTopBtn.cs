using UnityEngine.UI;
using UnityEngine;

public class NavTopBtn : MonoBehaviour
{
    [SerializeField] TournirData tournirData;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            AppManager.Instance.SetActiveTournir(tournirData);
        });
    }
}
