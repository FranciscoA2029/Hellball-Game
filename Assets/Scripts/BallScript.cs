using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{

    Rigidbody2D myBody;
    InputAction jump;
    InputAction right;
    InputAction left;
    InputAction reset;
    
    [SerializeField] float ballGravity;
    public int Score;
    public float randomRange;
    
    public float wallBounceStrength, spinnerBounceStrength, flierBounceStrength, dullerBounceStrength;
    
    void Start()
    {
        randomRange = Random.Range(-5f, 5f);
        Score = 0;
        myBody = GetComponent<Rigidbody2D>();
        
        //Playtesting Controls
        jump = InputSystem.actions.FindAction("Jump");
        right = InputSystem.actions.FindAction("Right1");
        left = InputSystem.actions.FindAction("Left1");
        
        //Reset and Initial Launch
        reset = InputSystem.actions.FindAction("Reset");
        myBody.AddForce(new Vector2(randomRange, 5000f));

    }

    // Update is called once per frame
    void Update()
    {
        // The actual Playtest functions and stuff.
        if (jump.IsPressed()) myBody.AddForce(new Vector2(0f, 100f));
        else if (right.IsPressed()) myBody.AddForce(new Vector2(30f, 0f));
        else if (left.IsPressed()) myBody.AddForce(new Vector2(-30f, 0f));
        
        myBody.AddForce(new Vector2(0f, -ballGravity));
        
        if (reset.WasReleasedThisFrame())
        {
            SceneManager.LoadScene("SampleScene");
            //transform.Translate(transform.position.x - startPosition.);
        }

        if (transform.position.y < -15) Score = 0;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Vector2 collisionSite = other.GetContact(0).normal;
            myBody.linearVelocity = collisionSite * wallBounceStrength;
            
        }
        else if (other.gameObject.CompareTag("Spinners"))
        {
            Vector2 collisionSite = other.GetContact(0).normal;
            myBody.linearVelocity = collisionSite * spinnerBounceStrength;
            Score++;
        }
        else if (other.gameObject.CompareTag("Fliers"))
        {
            Vector2 collisionSite = other.GetContact(0).normal;
            myBody.linearVelocity = collisionSite * flierBounceStrength;
            Score--;
        }
        else if (other.gameObject.CompareTag("Duller"))
        {
            Vector2 collisionSite = other.GetContact(0).normal;
            myBody.linearVelocity = collisionSite * dullerBounceStrength;
        }
    }
}
