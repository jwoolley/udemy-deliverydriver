using System.Collections.Generic;
using UnityEngine;

public class VehicleBehavior : MonoBehaviour {
  [SerializeField] static float DEFAULT_TERRAIN_SPEED_FACTOR = 1.0f;

  List<TerrainBehavior> terrainBehaviors = new List<TerrainBehavior>();

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

  public bool isPlayerVehicle() {
    return gameObject.GetComponentInChildren<Driver>() != null;
  }

}
