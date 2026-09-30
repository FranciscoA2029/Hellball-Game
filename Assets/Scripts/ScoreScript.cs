using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject scoreObject;
    public int playerScore = 0;

    BallScript Ball;
    
    void Start()
    {
        Ball = scoreObject.GetComponent<BallScript>();
    }
    

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Updating Score");
        //Debug.Log(Ball);
        
        scoreText.text = "Score:" + Ball.Score.ToString();
    }
}
