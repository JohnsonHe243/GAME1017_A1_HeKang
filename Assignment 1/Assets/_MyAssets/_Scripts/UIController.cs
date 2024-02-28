using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{
    [SerializeField] public Text scoreLabel; // for text obj

    // Update is called once per frame
    void Update()
    {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }

    public void onOpenSettings()
    {
        Debug.Log("open setting");
    }
}