using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    private static SaveData _current;

    public PlayerProfile profile;

    public List<ObjectsInGame> objects;
}
