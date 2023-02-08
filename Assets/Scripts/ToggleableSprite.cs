using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleableSprite : MonoBehaviour
{
    public void enable() {
      GetComponent<SpriteRenderer>().enabled = true;
    }
    public void disable() {
      GetComponent<SpriteRenderer>().enabled = false;
    }
}
