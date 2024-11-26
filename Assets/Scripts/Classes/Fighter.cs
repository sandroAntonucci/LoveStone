using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour, IEffect, IOnDamaged, IOnDead
{

    public int Damage;
    public int HP;
    public int Team;

    public void Attack(Fighter target)
    {
        target.HP -= Damage;

        Debug.Log(Damage + "damage applied");
    }

    public void Effect()
    {
        Debug.Log("Effect applied");
    }

    public void Effect(Fighter target)
    {
        Debug.Log("Effect applied to target");
    }

    public void Effect(Fighter[] targets)
    {
        Debug.Log("Effect applied to all targets");
    }

    public void OnDamaged()
    {
        Debug.Log("Fighter is damaged");
    }

    public void OnDead()
    {
        Debug.Log("Fighter is dead");
    }

}
