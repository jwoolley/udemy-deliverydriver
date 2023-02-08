using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DepotZoneBehavior : ZoneBehavior
{

  [SerializeField]
  DeliveryCompany company;

  private void Start() {
    label = GetComponentsInChildren<TMPro.TMP_Text>().Where(t => t.name == "Label").FirstOrDefault();
    label.text = company.getMonogram();
  }
  override public void onEnter(GameAgent agent) {
    if (agent != null && agent is PlayerGameAgent
      && LevelSceneManager.getLevelStateManager().hasPackage
      && (((agent as PlayerGameAgent).getParcel().getCompany()
        == this.company))) {
      Debug.Log("PACKAGE DELIVERED!");
      LevelStateManager.getInstance().triggerPackageDropoff();
      ToggleableSprite completedOverlay = GetComponentInChildren<ToggleableSprite>();
      if (completedOverlay != null) { completedOverlay.enable(); }
    } else {
      Debug.Log("PACKAGE REQUIRED");
    }
  }

  private TMPro.TMP_Text label;
}
