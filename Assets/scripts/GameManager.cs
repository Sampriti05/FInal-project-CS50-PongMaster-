using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public Text playerscoreText;
    public Text computerscoreText;
    private int playerscore;
    private int computerscore;

    public void playerscores()
    {
      playerscore++;
      Debug.Log(playerscore);
      this.playerscoreText.text = playerscore.ToString();
      ResetRound();//calling on reset functions

    }

    public void computerscores()
    {
      computerscore++;
      Debug.Log(computerscore);
      this.computerscoreText.text = computerscore.ToString();

      this.ball.ResetPosition();
      this.ball.AddStartingForce();
    }

   private void ResetRound()
   {
     this.ball.ResetPosition();
     this.playerPaddle.ResetPosition();
     this.computerPaddle.ResetPosition();
     this.ball.AddStartingForce();
   }
}
