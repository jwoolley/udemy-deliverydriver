using UnityEngine;

public class DeliveryCompany : MonoBehaviour {
  [SerializeField]
  private string companyName;

  [SerializeField]
  private char monogram;

  [SerializeField]
  private Color labelColor;

  public string getName() { return companyName; }

  public string getMonogram() { return monogram.ToString(); }
  public Color getLabelColor() { return labelColor; }
}