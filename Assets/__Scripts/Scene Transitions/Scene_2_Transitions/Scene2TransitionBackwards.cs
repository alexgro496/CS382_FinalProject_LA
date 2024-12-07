using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2TransitionBackwards : MonoBehaviour
{
    public static Vector3 playerPosition;
    
    void OnTriggerEnter(Collider Other){
        if (Other.CompareTag("Player")) {
        
            Vector3 pos = transform.position;
            pos.x = (float)7.5;
            pos.y = (float).75;
            MainCharacter.S.transform.position = pos;

            SceneManager.LoadScene("__Scene_1B");
        
            DontDestroyOnLoad(MainCharacter.S);
        }
    }
}
