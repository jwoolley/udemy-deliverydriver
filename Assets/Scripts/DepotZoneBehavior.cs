using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepotZoneBehavior : ZoneBehavior
{
  override public void onEnter(GameAgent agent) {
    if (LevelSceneManager.getLevelStateManager().hasPackage) {
      Debug.Log("PACKAGE DELIVERED!");
      LevelStateManager.getInstance().triggerPackageDropoff();
    } else {
      Debug.Log("PACKAGE REQUIRED");
    }
  }
}
