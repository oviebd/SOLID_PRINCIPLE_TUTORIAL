using UnityEngine;
using System.Collections;

public class Gun_LSP : Base_Weapon_LSP,IShootableWeapon_LSP
{

    public void Reload()
    {
        Debug.Log("Reloading .. " + name);
    }

    public void Shoot()
    {
        Debug.Log(name + " shooting with  " + damage + " damage per bullet");
    }


}
