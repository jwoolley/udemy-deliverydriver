using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerGameAgent : GameAgent
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void onParcelPickup(Parcel parcel) {
    // TODO: get color based off of parcel instead
    this.parcel = parcel;
    Color32 tintColor = new Color32(255, 100, 0, 0);
    getSpriteTinter().setTint(tintColor);
  }

  public Parcel getParcel() {
    return this.parcel;
  }

  public void onParcelDropOff(Parcel parcel) {
    getSpriteTinter().resetTint();
    this.parcel = null;
  }

  private SpriteTinter getSpriteTinter() {
    return gameObject.GetComponentInChildren<SpriteTinter>();
  }

  private Parcel parcel;
}
