using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepotZoneBehavior : ZoneBehavior
{
  override public void onEnter(GameAgent agent) {
    if (agent is PlayerGameAgent
      && LevelSceneManager.getLevelStateManager().hasPackage
      && ((agent as PlayerGameAgent).getParcel().getDepot() == null)
       || ((agent as PlayerGameAgent).getParcel().getDepot() == this))
       {
      Debug.Log("PACKAGE DELIVERED!");
      LevelStateManager.getInstance().triggerPackageDropoff();
    } else {
      Debug.Log("PACKAGE REQUIRED");
    }
  }
}
