
using UnityEngine;
public class GameAgent : MonoBehaviour {
  public void pickupObject(PickupBehavior pickup) {
    pickup.gameObject.SetActive(false);
    pickup.onPickup(this);
  }
}