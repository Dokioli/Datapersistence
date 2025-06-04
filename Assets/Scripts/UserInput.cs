using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;


public class UserInput : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TMP_InputField inputField;

    private void Start()
    {
        nameText.text = "Best Score: " + PlayerPrefs.GetString("PlayerName", "Player") + ":" + PlayerPrefs.GetInt("BestScore", 0);
    }

    public void SetText()
    {
        PlayerPrefs.SetString("PlayerName", inputField.text);
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }

}
