using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Riddle_Input : MonoBehaviour
{
    
    public TMP_InputField textInput;
    public Canvas inputCanvas;

    [SerializeField] private TextMeshProUGUI chatBox;

    public void Update(){
        if(((textInput.text.Trim().ToLower() == "mushroom") || (MainCharacter.S.Scene5RiddleCompletion == true)) && MainCharacter.S.Scene6Entered == false){
            MainCharacter.S.Scene5RiddleCompletion = true;
            MainCharacter.S.Scene5ChatCount = 0;
            chatBox.text = "Ah, clever human! You’ve solved it! I suppose you deserve to escape after all...";
            this.enabled = false;
            inputCanvas.enabled = false;
        }
    }
}
