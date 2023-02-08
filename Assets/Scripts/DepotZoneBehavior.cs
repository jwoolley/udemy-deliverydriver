using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepotZoneBehavior : ZoneBehavior
{
  override public void onEnter(GameAgent agent) {
    if (agent != null && agent is PlayerGameAgent
      && LevelSceneManager.getLevelStateManager().hasPackage
      && (((agent as PlayerGameAgent).getParcel().getDepot() == null)
       || ((agent as PlayerGameAgent).getParcel().getDepot() == this)))
       {
      Debug.Log("PACKAGE DELIVERED!");
      LevelStateManager.getInstance().triggerPackageDropoff();
      ToggleableSprite completedOverlay = GetComponentInChildren<ToggleableSprite>();
      if (completedOverlay != null) { completedOverlay.enable(); }
    } else {
      Debug.Log("PACKAGE REQUIRED");
    }
  }
}
