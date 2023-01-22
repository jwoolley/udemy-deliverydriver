using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour {
  private float currentRotation = 0f;
  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {

  }

  public void rotate(float angle) {
    if (currentRotation + angle * dRotation < maxRotation
        && currentRotation + angle > -maxRotation) {
      transform.Rotate(0f, 0f, angle * dRotation);
      currentRotation += angle * dRotation;
    }
  }

  public void resetRotation() {
    transform.Rotate(0f, 0f, -currentRotation);
    currentRotation = 0f;
  }

  [SerializeField] float maxRotation = 30f;
  [SerializeField] float dRotation = .75f;
  public void dequalizeRotation() {
    if (currentRotation != 0f) {
      float amount = currentRotation > 0f
         ? -Mathf.Min(dRotation, currentRotation)
         : -Mathf.Max(-dRotation, currentRotation);
      transform.Rotate(0f, 0f, amount);
      currentRotation += amount;
    }
  }
}
