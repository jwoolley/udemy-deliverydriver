using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStateManager : MonoBehaviour {
  [SerializeField]
  private static LevelStateManager _instance;
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

  private void onPickupPackage(Parcel parcel) {
    Debug.Log("Picked up package! Parcel: "
      + (parcel != null
      ? parcel.gameObject.name
      : "[no parcel assigned]"));
  }

  void Start() {
    if (_instance == null) {
      _instance = this;
    } else {
      Debug.LogWarning("Multiple LevelStateManagers found in scene");
    }
  }
}
