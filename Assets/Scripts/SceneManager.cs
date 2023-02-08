using UnityEngine;

public abstract class SceneManager : MonoBehaviour
{
    
    private static SceneManager _instance;
    void Awake() {
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
