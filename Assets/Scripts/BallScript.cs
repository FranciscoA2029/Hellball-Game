using UnityEngine;
using UnityEngine.InputSystem;

public class BallScript : MonoBehaviour
{

    Rigidbody2D myBody;
    InputAction jump;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        jump = InputSystem.actions.FindAction("Jump");

    }

    // Update is called once per frame
    void Update()
    {
        if (jump.IsPressed())
        {
            myBody.AddForce(new Vector2(0f, 500f));
        }
    }
}
