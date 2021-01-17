using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Non_SRP : MonoBehaviour
{
    [Header("Layers want to collided with")]
    public LayerMask layerMask = new LayerMask();

    private float speed = 6.0f;
    private int currentHealth = 100;

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(moveHorizontal * (-1), 0.0f, moveVertical * (-1)) * speed * Time.deltaTime;

        transform.position = transform.position + moveVector;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((layerMask.value & 1 << collision.gameObject.layer) != 0)
        {
            currentHealth = currentHealth - 5;
            Debug.Log("Player Health " + currentHealth);
        }
    }

}
