using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Non_LSP : Weapon_Non_LSP
{
    public override void Shoot()
    {
        Debug.Log(name + "shooting with  " + damage + " damage per bullet");
    }

    public override void Reload()
    {
        Debug.Log("Reloading .. " + name);
    }

    public override void Slash()
    {
        throw new System.NotImplementedException();
    }
}
