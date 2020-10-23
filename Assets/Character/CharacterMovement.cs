using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{

    float xInput = 0.0f;
    bool jumping = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(xInput);
        Debug.Log(jumping);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        xInput = context.ReadValue<float>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        jumping = context.ReadValueAsButton();
    }
}
