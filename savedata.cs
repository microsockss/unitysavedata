// Microsocks' savedata framework for use in Unity (C#)

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameData // Reference each entry to be saved (use default values)
{

    // Examples
    // public static bool EnteredGame = false;
    // public static int playerLevel;
    // public static int coins;
    // public static bool GreenSkin = true;
    
}

public class SaveData
{


    public static void Save() // Serialize each entry and store it in "gamesave.bin"
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        using (FileStream fs = new FileStream("gamesave.bin", FileMode.Create, FileAccess.Write))
        {

            // Examples
            // binaryFormatter.Serialize(fs, GameData.EnteredGame);
            // binaryFormatter.Serialize(fs, GameData.playerLevel);
            // binaryFormatter.Serialize(fs, GameData.coins);
            // binaryFormatter.Serialize(fs, GameData.GreenSkin);
            
        }
    }

    public static void Load() // Deserialize each entry and load save
    {
        if (!File.Exists("gamesave.bin"))
            return;

        BinaryFormatter binaryFormatter = new BinaryFormatter();
        using (FileStream fs = new FileStream("gamesave.bin", FileMode.Open, FileAccess.Read))
        {

            // Examples
            // GameData.EnteredGame = (bool)binaryFormatter.Deserialize(fs);
            // GameData.playerLevel = (int)binaryFormatter.Deserialize(fs);
            // GameData.coins = (int)binaryFormatter.Deserialize(fs);
            // GameData.GreenSkin = (bool)binaryFormatter.Deserialize(fs);
            
        }

        

    }

}
