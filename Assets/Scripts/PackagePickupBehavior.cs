using UnityEngine;

public class PackagePickupBehavior : PickupBehavior {
  [SerializeField]
  private Parcel parcel;
  
  public override bool isPickupable() {
    return !LevelSceneManager.getLevelStateManager().hasPackage;
  }
  public override void onPickup(GameAgent pickerUpper) {
      Parcel parcel = this.gameObject.GetComponentInChildren<Parcel>();
      LevelSceneManager.getLevelStateManager().triggerPackagePickup(parcel);
  }
}
