using UnityEngine;

public class Parcel : MonoBehaviour
{
    [SerializeField]
    DepotZoneBehavior depot;

    [SerializeField]
    Color32 pickupTintColor = Color.white;
  // Start is called before the first frame update


  public DepotZoneBehavior getDepot() {
    return depot;
  }
  public Color32 getPickupTintColor() {
    return pickupTintColor;
  }

  void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
