using UnityEngine;
public class Collision : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D other) {
    if (other != null) {
      CollisionBehavior cBehavior = other.gameObject.GetComponent<CollisionBehavior>();

      // TODO: implement this elsewhere
      if (cBehavior != null && cBehavior.isDestructible) {
        other.gameObject.SetActive(false);
      }
 
    }
  }

  private void OnTriggerEnter2D(Collider2D other) {
    if (other != null) {
      GameAgent gameAgent = gameObject.GetComponent<GameAgent>();
      VehicleBehavior vBehavior = gameObject.GetComponent<VehicleBehavior>();
      TerrainBehavior tBehavior = other.gameObject.GetComponent<TerrainBehavior>();
      PickupBehavior pBehavior = other.gameObject.GetComponent<PickupBehavior>();
      ZoneBehavior zBehavior = other.gameObject.GetComponent<ZoneBehavior>();

      if (vBehavior != null && tBehavior != null) {
        vBehavior.pushTerrainBehavior(tBehavior);
      }

      if (gameAgent != null && pBehavior != null) {
        gameAgent.pickupObject(pBehavior);
      }

      if (gameAgent != null && zBehavior != null) {
        gameAgent.enterZone(zBehavior);
      }
    }
    
    // TODO: change to use PickupBehavior / ZoneBehavior
    switch (other.tag) {
      case "Depot":
        Debug.Log("Package dropped off");
        break;
      default:
        break;
    }
  }

  private void OnTriggerExit2D(Collider2D other) {
    GameAgent gameAgent = gameObject.GetComponent<GameAgent>();
    ZoneBehavior zBehavior = other.gameObject.GetComponent<ZoneBehavior>();

    if (other != null) {
      VehicleBehavior vBehavior = this.gameObject.GetComponent<VehicleBehavior>();
      TerrainBehavior tBehavior = other.gameObject.GetComponent<TerrainBehavior>();
      if (vBehavior != null && tBehavior != null) {
        vBehavior.removeTerrainBehavior(tBehavior);
      }
    }

    if (gameAgent != null && zBehavior != null) {
      gameAgent.exitZone(zBehavior);
    }
  }
}
