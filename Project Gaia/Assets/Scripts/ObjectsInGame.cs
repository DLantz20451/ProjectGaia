using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum ObjectsInGame 
{
    Micheal,
    Enemy
}

[System.Serializable]
public class ObjectData
{
    public string id;

    public ObjectsInGame ObjectType;

    public Vector3 position;

    public Quaternion rotation;
}
