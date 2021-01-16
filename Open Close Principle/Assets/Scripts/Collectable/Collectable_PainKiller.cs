using UnityEngine;
using System.Collections;

public class Collectable_PainKiller : MonoBehaviour, ICollectable
{

    public void OnCollectableCollided()
    {
        Debug.Log("Pain killer will heal your life");
    }
}
