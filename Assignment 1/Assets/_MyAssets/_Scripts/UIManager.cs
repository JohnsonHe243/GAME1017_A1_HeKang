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
    public ScoreEntry() { }
    public ScoreEntry(string date, int value)
    {
        Date = date;
        Value = value;
    }
}

public class UIManager : MonoBehaviour
{
    [SerializeField] public SettingsPopup settingsPopup;
    [SerializeField] public TMP_Text score;
    [SerializeField] public TMP_Text date;
    int sceneIndex;

    public static UIManager Instance { get; private set; }

    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 1)
        {
            settingsPopup.Close();
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            DisplayScores();
        }


    }
    private void Update()
    {
        if (sceneIndex == 1 && PlayerMovement.Instance.isAlive == false)
        {
            SerializeToXml();
        }
    }

    public void SerializeToXml()
    {
        HighScores highScores = DeSerializeFromXml();
        highScores.Scores.Add(new ScoreEntry(PlayerMovement.Instance.GetCurrentDate(), PlayerMovement.Instance.finalScore));
        highScores.Scores = highScores.Scores.OrderByDescending(s => s.Value).ToList();
        highScores.Scores = highScores.Scores.Take(7).ToList();
        var serializer = new XmlSerializer(typeof(HighScores));

        // Use Application.persistentDataPath to get a path that works on all platforms
        string filePath = Path.Combine(Application.persistentDataPath, "Scores.xml");

        using (StreamWriter streamWriter = new StreamWriter(filePath))
        {
            serializer.Serialize(streamWriter, highScores);
        }
    }

    public void DisplayScores()
    {
        HighScores highScores = DeSerializeFromXml();
        foreach (var scoreEntry in highScores.Scores)
        {
            date.text += $"{scoreEntry.Date}\n";
            score.text += $"{scoreEntry.Value}\n";
        }
    }


    HighScores DeSerializeFromXml()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(HighScores));

        // Use Application.persistentDataPath to get a path that works on all platforms
        string filePath = Path.Combine(Application.persistentDataPath, "Scores.xml");

        if (File.Exists(filePath))
        {
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                return (HighScores)serializer.Deserialize(streamReader);
            }
        }
        else
        {
            // If the file doesn't exist, return a new instance of HighScores
            return new HighScores();
        }
    }
}
