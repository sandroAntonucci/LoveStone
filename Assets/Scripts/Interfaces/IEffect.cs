using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEffect
{

    public void Effect();

    public void Effect(Fighter target);

    public void Effect(Fighter[] targets);

}
