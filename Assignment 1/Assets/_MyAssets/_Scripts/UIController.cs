using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text scoreLabel; // for text obj

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }

    public void onOpenSettings() 
    {
        Debug.Log("open setting")
    }
}
