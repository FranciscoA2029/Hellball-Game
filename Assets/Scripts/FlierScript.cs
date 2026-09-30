using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FlierScript : MonoBehaviour
{
    [SerializeField] float flierSpeed;
    [SerializeField] int rightBounceBorder;
    [SerializeField] int leftBounceBorder;

    int turnCooldown;

    Boolean rotateFlier = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Rotate(new Vector3(0f, 0f, 30f));
    }

    // Update is called once per frame
    void Update()
    {
        turnCooldown--;
        
        if (transform.position.x > rightBounceBorder && turnCooldown < 0)
        {
            transform.Rotate(new Vector3(0f, 0f, 180f));
            rotateFlier = true;
            turnCooldown = 200;
        }
        if (transform.position.x < leftBounceBorder && turnCooldown < 0)
        {
            transform.Rotate(new Vector3(0f, 0f, 180f));
            rotateFlier = false;
            turnCooldown = 200;
        }
        if (!rotateFlier) transform.Translate(new Vector2(flierSpeed, -0.57735f * flierSpeed));
        if (rotateFlier) transform.Translate(new Vector2(flierSpeed, -0.57735f * flierSpeed));
    }
}
