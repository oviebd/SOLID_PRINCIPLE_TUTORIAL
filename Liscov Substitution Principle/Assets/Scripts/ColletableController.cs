using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColletableController : MonoBehaviour, ICollidable
{
    public enum CollectableType { Sword, Gun, Energy_Drink, Pain_Killer };

    public CollectableType type = CollectableType.Sword;

    ICollectable _collectable;

    private void Awake()
    {
        _collectable = this.gameObject.GetComponent<ICollectable>();
    }

    public void Oncollided(GameObject collidedObj)
    {
        _collectable.OnCollectableCollided();

        /*switch (type)
        {
            case CollectableType.Sword:
                Debug.Log("Use sword for slashing trolls");
                break;

            case CollectableType.Gun:
                Debug.Log("Use Gun for killing long distance enemy");
                break;

            case CollectableType.Energy_Drink:
                Debug.Log("Energy drink will boost your energy");
                break;

            case CollectableType.Pain_Killer:
                Debug.Log("Pain killer will heal your life");
                break;

            default:
                Debug.Log("UnDefined item collected");
                break;
        }*/
    }
}
