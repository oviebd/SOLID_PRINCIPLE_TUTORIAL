using UnityEngine;
using System.Collections;

public class Collectable_Gun : MonoBehaviour, ICollectable
{

    public void OnCollectableCollided()
    {
        Debug.Log("Use Gun for killing long distance enemy");
    }
}
