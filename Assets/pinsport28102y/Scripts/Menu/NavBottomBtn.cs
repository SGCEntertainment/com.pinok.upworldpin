using UnityEngine.UI;
using UnityEngine;

public class NavBottomBtn : MonoBehaviour
{
    [SerializeField] Sprite active;
    [SerializeField] Sprite disable;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            AppManager.Instance.SetActivePage(transform.GetSiblingIndex());
        });
    }

    public void SetActive(bool IsActive)
    {
        GetComponent<Image>().sprite = IsActive ? active : disable;
    }
}
