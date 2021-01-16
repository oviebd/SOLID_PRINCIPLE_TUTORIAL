using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_Non_LSP : Weapon_Non_LSP
{
    public override void Shoot()
    {
        throw new System.NotImplementedException();
    }

    public override void Reload()
    {
        throw new System.NotImplementedException();
    }

    public override void Slash()
    {
        Debug.Log("Slash with " + name + ".damage per slash is " + damage);

    }
}
