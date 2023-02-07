using UnityEngine;

public class PowerUpBehavior : PickupBehavior {
  [SerializeField] AbstractPowerUp powerUp;
  public override void onPickup(GameAgent pickerUpper) {
    if (powerUp == null) {
      Debug.LogWarning("PowerUpBehavior " + gameObject.name + "is missing AbstractPowerUp property");
      return;
    }
    powerUp.onPickup(pickerUpper);
  }
}