using UnityEngine;
using UnityEngine.EventSystems; //allows us ot have functions to keep track of both player and computer scores in one sheet rather than seperate

public class Scorezone : MonoBehaviour
{

  public EventTrigger.TriggerEvent scoreTrigger;

  private void OnCollisionEnter2D(Collision2D collision)
  {
    //when ball collides with zone it will trigger the event of the opposite player scoring
    Ball ball = collision.gameObject.GetComponent<Ball>();

    if(ball != null)
    {
      BaseEventData eventData = new BaseEventData(EventSystem.current);
      this.scoreTrigger.Invoke(eventData);

    }
  }
}
