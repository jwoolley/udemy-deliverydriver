using UnityEngine;

public class DeliveryCompanyRoster : MonoBehaviour
{
  // Start is called before the first frame update
    static private DeliveryCompanyRoster _instance;

    public static DeliveryCompanyRoster getInstance() { return _instance; }
    void Awake() {
      if (_instance == null) {
        _instance = this;
      }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
