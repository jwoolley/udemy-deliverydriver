using UnityEngine;

abstract public class ZoneBehavior : MonoBehaviour
{
  virtual public void onEnter(GameAgent zoneEnterer) { }
  virtual public void onExit(GameAgent zoneEnterer) { }
}
