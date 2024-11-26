using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Entity", menuName = "Entity")]
[System.Serializable]
public class EntitySO : ScriptableObject
{

    public string Name;
    public Sprite Design;
    public string Description;

}
