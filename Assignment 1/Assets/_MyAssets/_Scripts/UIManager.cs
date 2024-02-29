using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    private GameData gameData;
    [SerializeField] private SettingsPopup settingsPopup;
    private void Start()
    {
        gameData = new GameData();
        settingsPopup.Close();

        if (File.Exists("gameData.xml"))
        {
            // Deserialze the XML file to the gameData.
            gameData = DeserializeFromXml();
            // Update the kill count UI, access the set kill count method of enemy spawner

        }
    }

    public class GameData
    {
        public int killCount;
        public GameData()
        {
            killCount = 0;
        }
    }

    private GameData DeserializeFromXml()
    {   // From xml
        // Create an XmlSerializer for the GameData type.
        XmlSerializer serializer = new XmlSerializer(typeof(GameData));
        // Deserialize the GameData from XML.
        using (StreamReader streamReader = new StreamReader("gameData.xml"))
        {
            return (GameData)serializer.Deserialize(streamReader);
        }
    }

    private void DeleteFile()
    {
        if (File.Exists("gameData.xml"))
        {
            File.Delete("gameData.xml");
            Debug.Log("XML file deleted.");
        }
    }
}
