
using UnityEngine;
public class GameAgent : MonoBehaviour {
  public void pickupObject(PickupBehavior pickup) {
    pickup.gameObject.SetActive(false);
    pickup.onPickup(this);
  }

  public void enterZone(ZoneBehavior zone) {
    zone.onEnter(this);
  }

  public void exitZone(ZoneBehavior zone) {
    zone.onExit(this);
  }

  public VehicleBehavior getVehicleBehavior() {
    VehicleBehavior vBehavior = gameObject.GetComponent<VehicleBehavior>();
    if (vBehavior == null ) {
      Debug.LogWarning("GameAgent " + gameObject.name + " is missing VehicleBehavior");
    }
    return vBehavior;
  }
}