using UnityEngine;
using UnityEngine.UI;

public class WinTextScript : MonoBehaviour
{
    [SerializeField] private string textBefore;
    [SerializeField] private string textAfter;

    void Start()
    {
        if (PlayerPrefs.HasKey("WinPlayer"))
        {
            GetComponent<Text>().text = textBefore + PlayerPrefs.GetString("WinPlayer") + textAfter;
        }
    }
}