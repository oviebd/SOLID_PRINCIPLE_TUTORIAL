using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon_Non_LSP
{

    public string name { get; set; }
    public int damage { get; set; }

    public abstract void Shoot();
    public abstract void Reload();
    public abstract void Slash();

}
