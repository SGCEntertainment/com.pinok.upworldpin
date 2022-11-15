using UnityEngine.UI;
using UnityEngine;

public class NavBottomBtn : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            AppManager.Instance.SetActivePage(transform.GetSiblingIndex());
        });
    }
}
