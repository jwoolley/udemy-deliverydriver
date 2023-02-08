using System;
using System.Threading;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class DeliveryTimer : MonoBehaviour
{

  [SerializeField]
  Color color = Color.white;

  [SerializeField]
  DeliveryCompany company;

  public DeliveryCompany getCompany() { return company; }

  readonly string DEFAULT_TIME_TEXT = "0:00";
  readonly int MAX_DISPLAY_SECONDS = 99 * 60 + 59;


  public void startTimer() {
    Color runningColor = DeliveryTimerConfig.getInstance().getRunningColor();
    time.color = runningColor;
    watchIcon.color = runningColor;
    watchIcon.enabled = true;
    startTime = Time.time;
    isRunning = true;
  }
  public void stopTimer() {
    isRunning = false;
    watchIcon.enabled = false;
    time.color = color;
    endTime = Time.time;
  }

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
        if (isRunning) {
          float runtime = Time.time - startTime;
          if (runtime <= MAX_DISPLAY_SECONDS) {
            time.text = getTimeString(runtime);
          }
        }
    }

    private string getTimeString(float timeInSeconds) {
      int minutes = (int)Math.Floor(timeInSeconds / 60f);
      int seconds = (int)Math.Floor(timeInSeconds - minutes * 60f);
      return $"{minutes}:{seconds.ToString("00")}";
    }

    private TMPro.TMP_Text label;
    private TMPro.TMP_Text time;
    private Image watchIcon;
    private bool isRunning = false;
    private float startTime;
    private float endTime;
}
