using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Spell_Input : MonoBehaviour
{
    public TMP_InputField textInput;
    private bool hasExecuted = false;

    public void Update(){

        if(textInput.text.Trim().ToLower() == "spora invoco" && !hasExecuted){

            hasExecuted = true;

            Destroy(MainCharacter.S);

            Destroy(MainCharacter.S.gameObject);

            SceneManager.LoadScene("__Scene_7_Awake");
        }
    }
}
