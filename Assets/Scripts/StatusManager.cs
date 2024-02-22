using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusManager : MonoBehaviour {

    public static void Save(MonoBehaviour component, int slot = 1) {
        //Status status = (Status)component;
        //PlayerPrefs.SetInt("level", status.level);
        //PlayerPrefs.SetInt("lifes", status.lifes);
        
        PlayerPrefs.SetString("slot", JsonUtility.ToJson(component));
    }

    public static void Load(MonoBehaviour component, int slot = 1) {
        //Status status = (Status)component;
        //status.level = PlayerPrefs.GetInt("level");
        //status.lifes = PlayerPrefs.GetInt("lifes");
        JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString("slot"), component);
    }
}
