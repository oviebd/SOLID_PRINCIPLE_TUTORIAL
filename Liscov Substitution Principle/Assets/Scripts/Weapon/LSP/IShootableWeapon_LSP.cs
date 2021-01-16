using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootableWeapon_LSP : IWeapon_LSP
{
    void Shoot();
    void Reload();
}
