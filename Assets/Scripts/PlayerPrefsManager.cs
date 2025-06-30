using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsManager : MonoBehaviour
{
    public Text prefsText;

    void Start()
    {
        // Store Data
        PlayerPrefs.SetString("PlayerName", "Bridget");
        PlayerPrefs.SetInt("Score", 200);
        PlayerPrefs.SetFloat("Health", 90.5f);

        // Save the data
        PlayerPrefs.Save();

        // Retrieve Data
        string name = PlayerPrefs.GetString("PlayerName");
        int score = PlayerPrefs.GetInt("Score");
        float health = PlayerPrefs.GetFloat("Health");

        // Display in UI
        prefsText.text = $"PlayerPrefs Data:\nName: {name}\nScore: {score}\nHealth: {health}";
    }
}
