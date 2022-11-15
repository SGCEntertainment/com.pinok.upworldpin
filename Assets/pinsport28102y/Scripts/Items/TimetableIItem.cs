using UnityEngine.UI;
using UnityEngine;

public class TimetableIItem : MonoBehaviour
{
    public void SetData(TimetableData timetableData)
    {
        Image leftCommandImg = transform.Find("leftCommandIcon").GetComponent<Image>();
        Image rightCommandImg = transform.Find("rightCommandIcon").GetComponent<Image>();

        Text leftCommandNameText = transform.Find("leftCommandName").GetComponent<Text>();
        Text rightCommandNameText = transform.Find("rightCommandName").GetComponent<Text>();

        Text dateTimetableText = transform.Find("dateTimetable").GetComponent<Text>();

        leftCommandImg.sprite = timetableData.leftCommandIcon;
        rightCommandImg.sprite = timetableData.rightCommandIcon;

        leftCommandNameText.text = timetableData.leftCommandName;
        rightCommandNameText.text = timetableData.rightCommandName;

        dateTimetableText.text = timetableData.timeTableDate;
    }
}
