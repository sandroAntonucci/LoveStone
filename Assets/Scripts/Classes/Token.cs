using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : Fighter
{

    public int Position;
    public int CurrentDamage;
    public int CurrentHP;
    public CharacterSO Character;

    public void Start()
    {
        GameManager.Instance.UpdateTokenCanvas(gameObject);
    }

}
