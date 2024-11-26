using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : Invocable
{
    
    public EntitySO Entity;

    public void Start()
    {
        GameManager.Instance.UpdatePowerCanvas(gameObject);
    }

}
