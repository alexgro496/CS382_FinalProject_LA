using UnityEngine;
using TMPro;

public class Dialogue1 : MonoBehaviour{

    [SerializeField] private TextMeshProUGUI chatBox;
    [SerializeField] private Canvas restartButtonTrigger;

    void Awake(){
        chatBox.text = "Woah... Where am I?";
        restartButtonTrigger.enabled = false;
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.X)){
            MainCharacter.S.Scene1ChatCount++;
            UpdateDialogue();
        }
        if(MainCharacter.S.Scene1ChatCount >= 2){
            restartButtonTrigger.enabled = true;
        }
    }

    private void UpdateDialogue(){
        switch (MainCharacter.S.Scene1ChatCount){
            case 1:
                chatBox.text = "How did I get here? I need to find a way home.";
                break;
            default:
                chatBox.text = "";
                break;
        }
    }
}