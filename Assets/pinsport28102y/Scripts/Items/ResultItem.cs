using UnityEngine.UI;
using UnityEngine;

public class ResultItem : MonoBehaviour
{
    public void SetData(ResultData resultData, Texture2D texture)
    {
        RawImage background = transform.GetChild(0).GetComponent<RawImage>();
        background.texture = texture;
        background.SetNativeSize();

        Image leftCommandImg = transform.Find("leftCommandIcon").GetComponent<Image>();
        Image rightCommandImg = transform.Find("rightCommandIcon").GetComponent<Image>();

        Text leftCommandNameText = transform.Find("leftCommandName").GetComponent<Text>();
        Text rightCommandNameText = transform.Find("rightCommandName").GetComponent<Text>();

        Text dateTimetableText = transform.Find("dateTimetable").GetComponent<Text>();
        Text scoreText = transform.Find("scoreText").GetComponent<Text>();

        leftCommandImg.sprite = resultData.leftCommandIcon;
        rightCommandImg.sprite = resultData.rightCommandIcon;

        leftCommandNameText.text = resultData.leftCommandName;
        rightCommandNameText.text = resultData.rightCommandName;

        dateTimetableText.text = resultData.timeTableDate;
        scoreText.text = resultData.scoreString;
    }
}
