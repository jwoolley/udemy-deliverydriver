using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class DeliveryTimerConfig : MonoBehaviour
{
  [SerializeField]
  Color disabledColor = new Color32(180, 180, 180, 255);

  [SerializeField]
  Color runningColor = Color.yellow;

  private void Awake() {
    if (_instance == null) {
      _instance = this;
    }
  }

  public Color getDisabledColor() {
    return disabledColor;
  }

  public Color getRunningColor() {
    return runningColor;
  }

  public static DeliveryTimerConfig getInstance() {
    return _instance;
  }

  public void onPickup(Parcel parcel) {
    startTimer(parcel.getCompany());
  }


  public void onDropoff(Parcel parcel) {
    stopTimer(parcel.getCompany());
  }
  private void startTimer(DeliveryCompany company) {
    DeliveryTimer timer = getTimer(company);
      
    if (timer != null) {
      Debug.Log("Starting delivery timer for " + company.name);
      timer.startTimer();
    }
  }
  private void stopTimer(DeliveryCompany company) {
    DeliveryTimer timer = getTimer(company);

    if (timer != null) {
      Debug.Log("Stopping delivery timer for " + company.name);
      timer.stopTimer();
    }
  }

  private DeliveryTimer getTimer(DeliveryCompany company) {
    return GetComponentsInChildren<DeliveryTimer>()
      .FirstOrDefault(t => t.getCompany() == company);
  }

  private static DeliveryTimerConfig _instance;
}
