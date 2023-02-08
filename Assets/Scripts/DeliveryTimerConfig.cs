using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeliveryTimerConfig : MonoBehaviour
{
  [SerializeField]
  Color disabledColor = new Color32(180, 180, 180, 255);

  private void Start() {
    if (_instance == null) {
      _instance = this;
    }
  }

  public Color getDisabledColor() {
    return disabledColor;
  }

  public static DeliveryTimerConfig getInstance() {
    return _instance;
  }

  private static DeliveryTimerConfig _instance;
}
