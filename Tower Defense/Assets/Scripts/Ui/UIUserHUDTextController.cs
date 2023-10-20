using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIUserHUDTextController : MonoBehaviour
{
    [SerializeField] private Text[] targetExitText;
    [SerializeField] private string firstTextString;
    [SerializeField] private string lastTextString;
    private void OnChangeTargetValueAmount(string value)
    {
        foreach (var tText in targetExitText)
        {
            tText.text = $"{firstTextString}{value}{lastTextString}";
        }
    }
    public void OnChangeTargetValueAmount(int iValue)
    {
        OnChangeTargetValueAmount(iValue.ToString());
    }
    public void OnChangeTargetValueAmount(float fValue)
    {
        OnChangeTargetValueAmount(fValue.ToString());
    }
}