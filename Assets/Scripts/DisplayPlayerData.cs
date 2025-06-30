using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayPlayerData : MonoBehaviour
{
    public PlayerData playerData;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;
    public Image playerImage;

    void Start()
    {
        nameText.text = "Name: " + playerData.playerName;
        scoreText.text = "Score: " + playerData.playerScore;
        healthText.text = "Health: " + playerData.playerHealth;
        playerImage.sprite = playerData.playerIcon;

    }
}
