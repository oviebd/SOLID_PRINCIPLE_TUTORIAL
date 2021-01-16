using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Base_Weapon_LSP : IWeapon_LSP
{
    public string name { get; set; }
    public int damage { get; set; }
}
