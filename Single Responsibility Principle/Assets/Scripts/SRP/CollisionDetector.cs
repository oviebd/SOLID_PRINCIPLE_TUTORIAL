using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    [Header("Layers want to collided with")]
    public LayerMask layerMask = new LayerMask();

    private ICollidable iCollider;

    private void Awake()
    {
        iCollider = this.gameObject.GetComponent<ICollidable>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((layerMask.value & 1 << collision.gameObject.layer) != 0)
        {
            if (iCollider != null)
            {
                iCollider.Oncollided(collision.gameObject);
            }

        }
    }
}
public interface ICollidable
{
    void Oncollided(GameObject collidedObj);
}
