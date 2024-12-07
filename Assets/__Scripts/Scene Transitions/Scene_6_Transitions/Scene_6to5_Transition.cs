using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_6to5_Transition : MonoBehaviour{

    public static Riddle_Input Riddle_Input;
    
    public static Vector3 playerPosition;

    void OnTriggerEnter(Collider Other){
        
        if (Other.CompareTag("Player")) {
            Vector3 pos = transform.position;
            pos.x = 8;
            pos.y = (float)1.5;
            MainCharacter.S.transform.position = pos;

            
            SceneManager.LoadScene("__Scene_5_Scroll");

            DontDestroyOnLoad(MainCharacter.S);

            MainCharacter.S.Scene5ChatCount = 0;
            if (Riddle_Input != null){
                Riddle_Input.enabled = false;
             }
        // Vector3 pos = new Vector3(0,0,0);
        // pos.x = 8;
        // pos.y = (float)1.5;
        // MainCharacter.transform.position = pos;
        }
    }

}
