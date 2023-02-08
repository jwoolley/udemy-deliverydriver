using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class DeliveryCompanyRoster : MonoBehaviour
{
  // Start is called before the first frame update
  static private DeliveryCompanyRoster _instance;

  public static DeliveryCompanyRoster getInstance() { return _instance; }
  
  public IList<DeliveryCompany> getCompanies() { return _companies.AsReadOnlyList(); }

  void Awake() {
    if (_instance == null) {
      _instance = this;
    }
  }

  private void Start() {
    _companies = GetComponentsInChildren<DeliveryCompany>().ToList();
  }

  private List<DeliveryCompany> _companies;
}
