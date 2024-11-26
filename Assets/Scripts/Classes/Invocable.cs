using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invocable : MonoBehaviour
{
    public int Mana;
    public int CurrentMana;

    public void Play()
    {

        CurrentMana = Mana;

        return;
    }

}
