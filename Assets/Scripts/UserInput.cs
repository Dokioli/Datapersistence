using TMPro;
using UnityEngine;


public class UserInput : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TMP_InputField inputField;

    private void Start()
    {
        nameText.text = "Best Score: " + PlayerPrefs.GetString("PlayerName", "Player") + ":"+PlayerPrefs.GetInt("BestScore", 0);
    }

    public void SetText()
    {
        PlayerPrefs.SetString("PlayerName", inputField.text);
    }

}
