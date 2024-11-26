using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCard : Card
{

    public EntitySO Entity;

    public void Start()
    {
        GameManager.Instance.UpdateSpellCanvas(gameObject);
    }

}
