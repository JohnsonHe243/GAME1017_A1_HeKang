using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

[XmlRoot("Scores")]
public class HighScores
{
    [XmlArray("ScoreList")]
    [XmlArrayItem("ScoreEntry")]
    public List<ScoreEntry> Scores;
    public HighScores()
    {
        Scores = new List<ScoreEntry>();
    }
}

public class ScoreEntry
{
    [XmlAttribute("Date")]
    public string Date;
    [XmlAttribute("Value")]
    public int Value;
    public ScoreEntry(string date, int value)
    {
        Date = date;
        Value = value;
    }
}

public class UIManager : MonoBehaviour
{
    [SerializeField] public SettingsPopup settingsPopup;
    [SerializeField] public TMP_Text scoreT;
    [SerializeField] public TMP_Text dateT;
    private HighScores highScores;
    public string date;
    public int score;
    int sceneIndex;

    //public static UIManager Instance { get; private set; }

//    private void Start()
//    {
//        highScores = new HighScores();
//        sceneIndex = SceneManager.GetActiveScene().buildIndex;
//        if (SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 1)
//        {
//            settingsPopup.Close();
//        }
//        if (SceneManager.GetActiveScene().buildIndex == 2)
//        {
//            DisplayScores();

//        }
//        if (sceneIndex == 1 && PlayerMovement.Instance.isAlive == false)
//        {
//            date = PlayerMovement.Instance.GetCurrentDate();
//            score = PlayerMovement.Instance.finalScore;
//            SerializeToXml(highScores);
//        }
//        if (File.Exists("scores.xml"))
//        {
//            highScores = DeSerializeFromXml();
//        }
//    }

//    public void SerializeToXml(HighScores highScores)
//    {
//        highScores.Scores.Add(new ScoreEntry(date, score));
//        highScores.Scores = highScores.Scores.OrderByDescending(s => s.Value).ToList();
//        highScores.Scores = highScores.Scores.Take(7).ToList();
//        XmlSerializer serializer = new XmlSerializer(typeof(HighScores));

//        using (StreamWriter streamWriter = new StreamWriter("scores.xml"))
//        {
//            serializer.Serialize(streamWriter, highScores);
//        }
//    }

//    public void DisplayScores()
//    {
//        HighScores highScores = DeSerializeFromXml();
//        foreach (var scoreEntry in highScores.Scores)
//        {
//            dateT.text += $"{scoreEntry.Date}\n";
//            scoreT.text += $"{scoreEntry.Value}\n";
//        }
//    }


//    HighScores DeSerializeFromXml()
//    {
//        XmlSerializer serializer = new XmlSerializer(typeof(HighScores));

//        using (StreamReader streamReader = new StreamReader("scores.xml"))
//        {
//            return (HighScores)serializer.Deserialize(streamReader);
//        }

//    }
}
