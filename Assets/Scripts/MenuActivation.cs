using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuActivation : MonoBehaviour
{
    public Button menuButton;
    public Button pauseButton;
    public Button settingsButton;
    public Button creditsButton;
    public Button shopButton;
    public Image menuPanel;
    public TextMeshProUGUI pauseButtonText;

    bool isPaused = false;

    public void OpenMenuPanel()
    {
        menuPanel.gameObject.SetActive(true);
        //pauseButtonText = GetComponent<TextMeshPro
    }



    public void PauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0;
            isPaused = true;
            pauseButtonText.text = "Play";
        }
        else if (isPaused)
        {
            menuPanel.gameObject.SetActive(false);
            Time.timeScale = 1;
            pauseButtonText.text = "Pause";
            isPaused = false;
        }

    }

}
