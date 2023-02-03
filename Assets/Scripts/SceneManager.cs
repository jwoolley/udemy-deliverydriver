using UnityEngine;

public abstract class SceneManager : MonoBehaviour
{
    
    private static SceneManager _instance;
    // Start is called before the first frame update
    void Start() {
        if (_instance == null) {
          _instance = this;
        } else {
          Debug.LogWarning("Multiple SceneManagers found in scene");
        }
    }

  public static SceneManager getInstance() {
    return _instance;
  }

    // Update is called once per frame
    void Update()
    {
        
    }
}
