using System.Collections;
using UnityEngine;

public class SettingsPopup : MonoBehaviour
{
    public void Open()
    {
        gameObject.SetActive(true); // Turn the Object on (opens the panel)
        PauseGame();
    }

    public void Close()
    {
        gameObject?.SetActive(false); // Object off (close panel) 
        ResumeGame();
    }
    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
