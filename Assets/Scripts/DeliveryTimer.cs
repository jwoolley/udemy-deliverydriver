using System;
using UnityEngine;
using UnityEngine.UI;

public class DeliveryTimer : MonoBehaviour
{

  [SerializeField]
  Color color = Color.white;

  [SerializeField]
  DeliveryCompany company;

  readonly string DEFAULT_TIME_TEXT = "0:00";
  // Start is called before the first frame update
  bool isRunning = false;
  void Start() {
    label = transform.Find("Label").GetComponent<TMPro.TMP_Text>();
    label.color = company.getLabelColor();
    label.text = company.getName();

    time = transform.Find("Time").GetComponent<TMPro.TMP_Text>();
    time.color = DeliveryTimerConfig.getInstance().getDisabledColor();
    time.text = DEFAULT_TIME_TEXT;

    watchIcon = transform.Find("WatchIcon").GetComponent<Image>();
    watchIcon.color = company.getLabelColor();
    watchIcon.enabled = false;
  }

    // Update is called once per frame
    void Update() {
        
    }

    private TMPro.TMP_Text label;
    private TMPro.TMP_Text time;
    private Image watchIcon;
}
