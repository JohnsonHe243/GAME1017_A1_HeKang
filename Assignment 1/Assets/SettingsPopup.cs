using System.Collections;
using UnityEngine;

public class SettingsPopup : MonoBehaviour
{
    public void Open()
    {
        gameObject.SetActive(true); // Turn the Object on (opens the panel)
    }

    public void Close()
    {
        gameObject?.SetActive(false); // Object off (close panel) 
    }    
}
