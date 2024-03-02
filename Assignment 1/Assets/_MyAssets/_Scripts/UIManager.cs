using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

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
    private const string xmlFilePath = "Assets/Scores.xml";

    private void Start()
    {
        settingsPopup.Close();
        DisplayScores();
    }

    public void SerializeToXml(string date, int score)
    {
        HighScores highScores = DeSerializeFromXml();
        highScores.Scores.Add(new ScoreEntry(date, score));
        highScores.Scores = highScores.Scores.OrderByDescending(s => s.Value).ToList();
        highScores.Scores = highScores.Scores.Take(7).ToList();
        var serializer = new XmlSerializer(typeof(HighScores));

        using (StreamWriter streamWriter = new StreamWriter("Assets/Scores.xml"))
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
        // Deserialize the GameData from XML.
        using (StreamReader streamReader = new StreamReader("Assets/Scores.xml"))
        {
            return (HighScores)serializer.Deserialize(streamReader);
        }
    }




}
