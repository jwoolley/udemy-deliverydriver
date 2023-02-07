using System.Collections.Generic;
using UnityEngine;

public class VehicleBehavior : MonoBehaviour {
  [SerializeField] static float DEFAULT_TERRAIN_SPEED_FACTOR = 1.0f;
  [SerializeField] static float DEFAULT_BOOST_SPEED_FACTOR = 1.0f;

  List<TerrainBehavior> terrainBehaviors = new List<TerrainBehavior>();
  List<(float speedFactor, float duration)> speedBoosts = new List<(float, float)>();

  public void pushTerrainBehavior(TerrainBehavior terrainBehavior) {
    terrainBehaviors.Add(terrainBehavior);
  }

  public void removeTerrainBehavior(TerrainBehavior terrainBehavior) {
    terrainBehaviors.Remove(terrainBehavior);
  }

  public float getCurrentTerrainSpeedFactor() {
    if (terrainBehaviors.Count > 0) {
      return terrainBehaviors[terrainBehaviors.Count - 1].terrainSpeedFactor;
    };
    return DEFAULT_TERRAIN_SPEED_FACTOR;
  }

  public void applySpeedBoost(float speedFactor, float duration) {
    pushSpeedBoost(speedFactor, duration);
  }

  private void pushSpeedBoost(float amount, float duration) {
    speedBoosts.Add( (amount,duration) );
  }

  public void removeSpeedBoost(TerrainBehavior terrainBehavior) {
    terrainBehaviors.Remove(terrainBehavior);
  }

  public float getCurrentBoostSpeedFactor() {
    if (speedBoosts.Count > 0) {
      return speedBoosts[speedBoosts.Count - 1].speedFactor;
    };
    return DEFAULT_BOOST_SPEED_FACTOR;
  }

  public bool isPlayerVehicle() {
    return gameObject.GetComponentInChildren<Driver>() != null;
  }

  public void Update() {
    updateSpeedBoosts();
  }

  private void updateSpeedBoosts() {
    if (speedBoosts.Count > 0) {
      int index = speedBoosts.Count - 1;
      (float speedFactor ,float duration) currentBoost = speedBoosts[index];
     
      if (currentBoost.duration - Time.deltaTime > 0) {
        speedBoosts[index] = (currentBoost.speedFactor, currentBoost.duration - Time.deltaTime);
      } else {
        speedBoosts.RemoveAt(index);
      }
    };
  }
}
