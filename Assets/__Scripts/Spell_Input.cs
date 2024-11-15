using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Spell_Input : MonoBehaviour
{
    public TMP_InputField textInput;
    public GameObject MushroomQueen;

    public void Update(){
        if(textInput.text == "spora invoco"){
            SceneManager.LoadScene("__Scene_7_Awake");
        }
    }

}
