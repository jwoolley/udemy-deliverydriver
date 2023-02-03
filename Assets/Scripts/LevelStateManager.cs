using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStateManager : MonoBehaviour {
  [SerializeField]
  private static LevelStateManager _instance;
  [SerializeField]
  private PlayerGameAgent playerGameAgent;
  public static LevelStateManager getInstance() {
    return _instance;
  }

  [SerializeField]
  public Boolean hasPackage {  get; private set; } = false;

  public void triggerPackagePickup(Parcel parcel) {
    if (!hasPackage) {
      hasPackage = true;
      onPickupPackage(parcel);
    } else {
      Debug.Log("Already hasPackage; trigger skipped");
    }
  }

  public void triggerPackageDropoff() {
    if (hasPackage) {
      hasPackage = false;
      onDropPackage(playerGameAgent.getParcel());
    } else {
      Debug.Log("Already has no package; trigger skipped");
    }
  }

  private void onPickupPackage(Parcel parcel) {
    playerGameAgent.onParcelPickup(parcel);
    Debug.Log("Picked up package! Parcel: "
      + (parcel != null
      ? parcel.gameObject.name
      : "[no parcel assigned]"));
  }

  private void onDropPackage(Parcel parcel) {
    playerGameAgent.onParcelDropOff(parcel);
    Debug.Log("Dropped off package!");
  }
  void Start() {
    if (_instance == null) {
      _instance = this;
    } else {
      Debug.LogWarning("Multiple LevelStateManagers found in scene");
    }
  }
}
