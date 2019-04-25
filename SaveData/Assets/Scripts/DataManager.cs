using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class DataManager
{
    private static string _path = Application.persistentDataPath + "/player_data.dat";

    public static void SaveData(PlayerController player)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream stream = new FileStream(_path, FileMode.Create);

        PlayerData playerData = new PlayerData(player);

        formatter.Serialize(stream, playerData);
        stream.Close();
    }

    public static PlayerData LoadData()
    {
        if (File.Exists(_path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(_path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log($"File not found: {_path}");
            return null;
        }
    }
}
