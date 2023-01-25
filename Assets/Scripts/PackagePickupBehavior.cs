using UnityEngine;

public class PackagePickupBehavior : PickupBehavior {
  public override void onPickup(GameAgent pickerUpper) {
    Debug.Log("Package picked up");
  }
}
