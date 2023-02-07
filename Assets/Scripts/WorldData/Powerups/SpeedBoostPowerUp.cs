using UnityEngine;
public class SpeedBoostPowerUp : AbstractPowerUp {
  [SerializeField]
  float speedBoostFactor = 2.0f;

  [SerializeField]
  float duration = 3.0f; // seconds
  public override void onPickup(GameAgent agent) {
    Debug.Log("SpeedBoost picked up by " + agent.gameObject.name);
    VehicleBehavior vBehavior = agent.getVehicleBehavior();
    if (vBehavior != null) {
      vBehavior.applySpeedBoost(speedBoostFactor, duration);
    }
  }
}