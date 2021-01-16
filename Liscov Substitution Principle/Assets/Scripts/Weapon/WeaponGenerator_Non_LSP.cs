using UnityEngine;
using System.Collections;

public class WeaponGenerator_Non_LSP : MonoBehaviour
{

    private void Start()
    {
        GenerateSword();
        GenerateGun();
    }

    void GenerateSword()
    {
        Weapon_Non_LSP sword = new Sword_Non_LSP();

        sword.name = "sowrd 1";
        sword.damage = 10;
        sword.Slash();

        try
        {
            sword.Shoot();
        }
        catch
        {
            Debug.Log("Sword can not shoot");
        }
    }



    void GenerateGun()
    {
        Weapon_Non_LSP gun = new Gun_Non_LSP();

        gun.name = "gun 1";
        gun.damage = 5;
        gun.Shoot();

        try
        {
            gun.Slash();
        }
        catch
        {
            Debug.Log("Gun can not slash");
        }


    }
}
