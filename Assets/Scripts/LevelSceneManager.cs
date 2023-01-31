using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSceneManager : SceneManager
{
    public static LevelStateManager _levelStateManager;
    
    static public LevelStateManager getLevelStateManager() {
      return LevelStateManager.getInstance();
    }
    // Start is called before the first frame update
    void Start() {
    }
    // Update is called once per frame
    void Update()
    { }
}
