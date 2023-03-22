using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle player2Paddle;
    public Text playerScoreText;
    public Text player2ScoreText;
    private int playerScore;
    private int player2Score;

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ResetRound();
    }

    public void Player2Scores()
    {
        player2Score++;
        this.player2ScoreText.text = player2Score.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        playerPaddle.ResetPosition();
        this.player2Paddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
