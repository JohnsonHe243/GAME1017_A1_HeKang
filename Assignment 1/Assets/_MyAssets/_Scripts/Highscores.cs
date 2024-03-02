using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Highscores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists("Scores.xml"))
        {
            UIManager.Instance.DisplayScores();
        }

    }

}
