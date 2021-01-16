using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // public delegate void GameAudioStateChange(bool isAudioOn);
    //public static event GameAudioStateChange onAudioStateChange;

    public static InputManager instance;

    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;
    }

    public float GetHorizontalAxisValue()
    {
        return Input.GetAxis("Horizontal");
    }

    public float GetVerticalAxisValue()
    {
        return Input.GetAxis("Vertical");
    }

}
