using System.Linq;
using UnityEngine;

public class Parcel : MonoBehaviour
{

    [SerializeField]
    DeliveryCompany company;

    [SerializeField]
    Color32 pickupTintColor = Color.white;
  // Start is called before the first frame update


  public DeliveryCompany getCompany() {
    return company;
  }
  public Color32 getPickupTintColor() {
    return pickupTintColor;
  }

  void Start() {
    label = GetComponentsInChildren<TMPro.TMP_Text>().Where(t => t.name == "Label").FirstOrDefault();
    label.text = company.getMonogram();
  }
    // Update is called once per frame
    void Update()
    {
        
    }

    private TMPro.TMP_Text label;
}
