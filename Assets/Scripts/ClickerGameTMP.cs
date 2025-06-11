using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClickerGameTMP : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Button upgradeButton;
    private int score = 0;
    private int clickValue = 1;

    void Start()
    {
        UpdateScoreText();
        if (upgradeButton != null)
            upgradeButton.gameObject.SetActive(false);
    }

    public void OnClickButton()
    {
        score += clickValue;
        UpdateScoreText();

        if (score >= 25 && upgradeButton != null)
            upgradeButton.gameObject.SetActive(true);
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("score", score);
    }

    public void LoadScore()
    {
        score = PlayerPrefs.GetInt("score", 0);
        UpdateScoreText();
    }

    public void ApplyUpgrade()
    {
        clickValue = 5;
        if (upgradeButton != null)
            upgradeButton.interactable = false;
    }

    void UpdateScoreText()
    {
        scoreText.text = "Punkte: " + score.ToString();
    }
}
