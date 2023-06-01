using UnityEngine;

public class Computerpaddle : Paddle
{
  public Rigidbody2D ball;

  private void FixedUpdate() //physics related functions
  {
    if(this.ball.velocity.x > 0.0f)//logic if ball is going towards player paddle
    {
      if(this.ball.position.y > this.transform.position.y)
      {
        _rigidbody.AddForce(Vector2.up * this.speed);
      }

      else if(this.ball.position.y < this.transform.position.y)
      {
        _rigidbody.AddForce(Vector2.down * this.speed);
      }
    }

    else //logic if ball is moving towards computer paddle
    {
      if(this.transform.position.y > 0.0f)
      {
        _rigidbody.AddForce(Vector2.down * this.speed);

      }
      else if(this.transform.position.y < 0.0f)
      {
        _rigidbody.AddForce(Vector2.up * this.speed);
      }
    }
  }

}
