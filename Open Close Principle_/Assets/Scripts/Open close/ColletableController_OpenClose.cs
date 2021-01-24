using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColletableController_OpenClose : MonoBehaviour, ICollidable
{

    ICollectable _collectable;

    private void Awake()
    {
        _collectable = this.gameObject.GetComponent<ICollectable>();
    }

    public void Oncollided(GameObject collidedObj)
    {
        _collectable.OnCollectableCollided();
    }
}
