using UnityEngine;

public class Collision : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D other) {
    if (other != null) {
      CollisionBehavior cBehavior = other.gameObject.GetComponent<CollisionBehavior>();
      if (cBehavior != null && cBehavior.isDestructible) {
        other.gameObject.SetActive(false);
      }
    }
  }

  private void OnTriggerEnter2D(Collider2D other) {
    if (other != null) {
      VehicleBehavior vBehavior = this.gameObject.GetComponent<VehicleBehavior>();
      TerrainBehavior tBehavior = other.gameObject.GetComponent<TerrainBehavior>();
      if (vBehavior != null && tBehavior != null) {
        vBehavior.pushTerrainBehavior(tBehavior);
      }
    }
  }

  private void OnTriggerExit2D(Collider2D other) {
    if (other != null) {
      VehicleBehavior vBehavior = this.gameObject.GetComponent<VehicleBehavior>();
      TerrainBehavior tBehavior = other.gameObject.GetComponent<TerrainBehavior>();
      
      if (vBehavior != null && tBehavior != null) {
        vBehavior.removeTerrainBehavior(tBehavior);

      }
    }
  }
}
