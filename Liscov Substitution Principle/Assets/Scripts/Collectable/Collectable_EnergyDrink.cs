﻿using UnityEngine;
using System.Collections;

public class Collectable_EnergyDrink : MonoBehaviour, ICollectable
{

    public void OnCollectableCollided()
    {
        Debug.Log("Energy drink will boost your energy");
    }
}
