using UnityEngine;
using System.Collections;

public class Sword_LSP : Base_Weapon_LSP, ISlahableWeapon_LSP
{
    public void Slash()
    {
        Debug.Log("Slashing with " + name + ".damage per slash is " + damage);
    }
}
