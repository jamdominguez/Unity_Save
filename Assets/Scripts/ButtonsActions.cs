using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsActions : MonoBehaviour {

    public Status status;

    public void Save(int slot) {
        Debug.Log("Save slot: " + slot);
        StatusManager.Save(status, slot);
    }

    public void Load(int slot) {
        Debug.Log("Load slot: " + slot);
        StatusManager.Load(status, slot);
    }
}
