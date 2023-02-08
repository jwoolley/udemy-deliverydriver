using UnityEngine;

public class DeliveryCompany : MonoBehaviour {
  [SerializeField]
  private string companyName;

  [SerializeField]
  private Color labelColor;

  public string getName() { return companyName; }
  public Color getLabelColor() { return labelColor; }
}