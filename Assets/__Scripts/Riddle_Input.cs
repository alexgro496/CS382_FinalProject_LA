using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Riddle_Input : MonoBehaviour
{
    public TMP_InputField textInput;
    [SerializeField] private TextMeshProUGUI chatBox;

    public void Update(){
        if(textInput.text == "mushroom"){
            chatBox.text = "spora invoco";
        }
    }
}
