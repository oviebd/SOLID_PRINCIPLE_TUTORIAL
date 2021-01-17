using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float speed = 6.0f;
   
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float moveHorizontal = InputManager.instance.GetHorizontalAxisValue();
        float moveVertical = InputManager.instance.GetVerticalAxisValue();

        Vector3 moveVector = new Vector3(moveHorizontal * (-1), 0.0f, moveVertical * (-1)) * speed * Time.deltaTime;
        transform.position = transform.position + moveVector;
    }
}
