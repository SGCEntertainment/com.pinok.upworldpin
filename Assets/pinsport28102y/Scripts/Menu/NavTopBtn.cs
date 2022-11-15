using UnityEngine.UI;
using UnityEngine;

public class NavTopBtn : MonoBehaviour
{
    [SerializeField] Color active;
    [SerializeField] Color disable;

    [Space(10)]
    public TournirData tournirData;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            AppManager.Instance.SetActiveTournir(tournirData);
        });
    }

    public void SetActive(bool IsActive)
    {
        transform.GetChild(0).GetComponent<Text>().color = IsActive ? active : disable;
    }
}
