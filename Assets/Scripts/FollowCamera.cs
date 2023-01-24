using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
  [SerializeField]
  private GameObject followTarget;
  // Start is called before the first frame update
  // Update is called once per frame
  private void Start() {
    float cameraOffsetZ = transform.position.z - followTarget.transform.position.z;
    Debug.Log("Camera Position: " + transform.position);
    Debug.Log("Car Position: " + followTarget.transform.position);
    Debug.Log("cameraOffsetZ: " + cameraOffsetZ);
  }

  private void LateUpdate() {
      float cameraOffsetZ = transform.position.z - followTarget.transform.position.z;
      this.transform.position = followTarget.transform.position + new Vector3(0f, 0f, cameraOffsetZ);
  }

    
}
