using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchFlip : MonoBehaviour
{
    
    Rigidbody2D flipBody;
    InputAction right;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flipBody = GetComponent<Rigidbody2D>();
        right = InputSystem.actions.FindAction("Right");
    }

    // Update is called once per frame
    void Update()
    {
        //flipBody.AddTorque(60f, ForceMode2D.Impulse);
        //flipBody.AddForce(transform.up * 800);
        //if (Input.GetKey(KeyCode.D)) Debug.Log("Tried Flipping"); Testing stuff
        
        if (right.IsPressed())
        {
            Debug.Log("Flipping");
            flipBody.AddTorque(100f, ForceMode2D.Impulse);
            //flipBody.AddForce(transform.up * 8000);
        }
    }
}
