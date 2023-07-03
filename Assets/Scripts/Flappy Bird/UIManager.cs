using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

// Những script sử dụng các component của UI thì sẽ cần using UnityEngine.UI
public class UIManager : MonoBehaviour
{
    public static UIManager Instance = null;

    public GameObject buttonStartGame;
    public TextMeshProUGUI textScore;

    public GameObject loseGamePanel;
    public GameObject BronzeMedal;
    public GameObject SilverMedal;
    public GameObject GoldMedal;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        UpdateScore(0);
    }

    public void StartGameOnClicked()
    {
        GameManager.Instance.StartGame();
        buttonStartGame.SetActive(false);
    }
    
    public void PauseGame()
    {
        GameManager.Instance.PauseGame();
    }

    public void UpdateScore(int score)
    {
        textScore.text = score.ToString();
    }

    public void LoseGame()
    {
        loseGamePanel.SetActive(true);
    }

    public void UpdateMedal(int score)
    {
        GoldMedal.SetActive(false);
        SilverMedal.SetActive(false);
        BronzeMedal.SetActive(false);

        if (score >= 6)
        {
            GoldMedal.SetActive(true);
            SilverMedal.SetActive(false);
            BronzeMedal.SetActive(false);
        }

        else if (score <= 5 && score >= 3)
        {
            SilverMedal.SetActive(true);
            GoldMedal.SetActive(false);
            BronzeMedal.SetActive(false);
        }

        else if (score < 3)
        {
            BronzeMedal.SetActive(true);
            SilverMedal.SetActive(false);
            GoldMedal.SetActive(false);
        }

    }

}
