using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class CharacterCard : Card
{

    public CharacterSO Character;


    public void Start()
    {
        GameManager.Instance.UpdateCharacterCanvas(gameObject);
    }

    public void Invoke(Token token)
    {
        return;
    }

}
