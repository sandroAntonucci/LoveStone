using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : Fighter
{

    public Power Power;
    public int Armor;
    public EntitySO EntitySO;

    public void Start()
    {
        GameManager.Instance.UpdateAvatarCanvas(gameObject);
    }

    public void Interact()
    {
        return;
    }


}
