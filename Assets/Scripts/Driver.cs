using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 300f;
    [SerializeField] float moveSpeed = 5f;

    Wheel[] wheels;
  void Start(){
    wheels = GetComponentsInChildren<Wheel>();
    Debug.Log("Found wheels: " + wheels.Length);
  }

    void Update() {
      float steerAmount = Input.GetAxis("Horizontal") * Time.deltaTime;
      float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime;
      if (Math.Abs(steerAmount) > 0.0001f) {
        foreach (Wheel wheel in wheels) {
          wheel.rotate(-Mathf.Clamp(steerAmount*steerSpeed*.5f, -0.8f , 0.8f));
        }
      } else {
        foreach (Wheel wheel in wheels) {
          wheel.dequalizeRotation();
        }
      }

      if (Mathf.Abs(moveAmount) > 0f) {
        transform.Rotate(0f, 0f, -steerAmount * steerSpeed);
        transform.Translate(0f, moveAmount * moveSpeed, 0f);
      }
  }

    void rotateWheels(float angle) {

    }
  float normalizeSpeed(float rotationAmount) {
    return rotationAmount * rotationAmount;
  }
}
