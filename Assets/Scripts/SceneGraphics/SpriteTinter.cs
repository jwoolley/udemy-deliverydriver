using UnityEngine;


public class SpriteTinter : MonoBehaviour
{
  private static float DEFAULT_TINT_ALPHA = 0.8f;

  // Start is called before the first frame update
  [SerializeField]
  SpriteRenderer spriteRenderer;
  void Start() {
    if (this.spriteRenderer == null) {
      Debug.LogWarning("No SpriteRenderer se or found for " + this.name);
    }
  }

  public void setTint(Color color) {
    this.spriteRenderer.color = new Color(color.r, color.g, color.b, getTintAlpha());
    this.spriteRenderer.enabled= true;
  }

  public void resetTint() {
    this.spriteRenderer.enabled = false;
    this.spriteRenderer.color = Color.white;
  }

  private float getTintAlpha() {
    return DEFAULT_TINT_ALPHA;
  }
}
