using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class PickupBehavior : MonoBehaviour {

  private void Start() {
    if (gameObject.GetComponentInChildren<Collider2D>() == null) {
      Debug.LogWarning("PickupBehavior attached to GameObject without attached collider: " + gameObject.name);
    }
  }

  public abstract void onPickup(GameAgent pickerUpper);
}
