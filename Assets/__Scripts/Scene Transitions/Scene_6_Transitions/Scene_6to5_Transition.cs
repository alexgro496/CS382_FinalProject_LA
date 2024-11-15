using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_6to5_Transition : MonoBehaviour{

    public static Vector3 playerPosition;

    void OnTriggerEnter(Collider Other){
        
        Vector3 pos = transform.position;
        pos.x = 8;
        pos.y = (float)1.5;
        MainCharacter.S.transform.position = pos;
        
        SceneManager.LoadScene("__Scene_5_Scroll");

        DontDestroyOnLoad(MainCharacter.S);

        // Vector3 pos = new Vector3(0,0,0);
        // pos.x = 8;
        // pos.y = (float)1.5;
        // MainCharacter.transform.position = pos;
    }

}
