using UnityEngine;
using UnityEngine.UI;

public class OpenGameBtn : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            AppManager.Instance.SetGame();
        });
    }
}
