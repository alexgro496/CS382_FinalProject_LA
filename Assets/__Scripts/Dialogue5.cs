using UnityEngine;
using TMPro;

public class Dialogue5 : MonoBehaviour{

    [SerializeField] private TextMeshProUGUI chatBox;
    private bool canTalk;

    void Update(){
        if (canTalk && Input.GetKeyDown(KeyCode.X))
        {
            MainCharacter.S.Scene5ChatCount++;
            UpdateDialogue();
        }
    }

    private void UpdateDialogue(){
        switch (MainCharacter.S.Scene5ChatCount){
            case 1:
                chatBox.text = "Hello Stranger!";
                break;
            case 2:
                chatBox.text = "What brings you here?";
                break;
            case 3:
                chatBox.text = "Goodbye for now!";
                break;
            default:
                chatBox.text = "";  
                break;
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){ 
            canTalk = true;  
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.CompareTag("Player")){ 
            canTalk = false;
        }
    }
}