using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public TMP_Text  playerScoreText;
    public TMP_Text  computerScoreText;
    public Ball ball;
    private int playerScore;
    private int computerScore;
    public void PlayerScores(){
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ResetRound();
    }
    public void ComputerScores(){
        computerScore++;
        computerScoreText.text = computerScore.ToString();
        ResetRound();
    }

    private void ResetRound(){
        ball.ResetPosition();
        ball.AddStartingForce();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
    }
}
