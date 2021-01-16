using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGenerator_LSP : MonoBehaviour
{
    private void Start()
    {
        GenerateSword();
        GenerateGun();
    }

    void GenerateSword()
    {
        ISlahableWeapon_LSP sword = new Sword_LSP();

        sword.name = "sowrd 1";
        sword.damage = 10;
        sword.Slash();
    }



    void GenerateGun()
    {
        IShootableWeapon_LSP gun = new Gun_LSP();

        gun.name = "gun 1";
        gun.damage = 5;
        gun.Shoot();
    }
}
