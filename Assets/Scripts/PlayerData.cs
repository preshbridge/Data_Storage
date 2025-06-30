using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerData", menuName = "Data/PlayerData")]
public class PlayerData : ScriptableObject
{
    public string playerName;
    public int playerScore;
    public float playerHealth;
    public Sprite playerIcon;

}
