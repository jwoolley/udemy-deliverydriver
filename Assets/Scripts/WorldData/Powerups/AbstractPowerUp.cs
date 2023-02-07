using System;
using UnityEngine;
public abstract class AbstractPowerUp : MonoBehaviour {
  abstract public void onPickup(GameAgent agent);
}