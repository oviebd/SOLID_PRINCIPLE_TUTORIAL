using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour,ICollidable
{
    public int currentHealth = 100;

    public void Oncollided(GameObject collidedObj)
    {
        currentHealth = currentHealth - 5;

        Debug.Log("Player Health " + currentHealth);
    }
}
