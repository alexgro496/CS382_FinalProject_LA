using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue7 : MonoBehaviour{

    [SerializeField] private TextMeshProUGUI chatBox;
    [SerializeField] private Canvas restartButtonTrigger;

    void Awake(){
        chatBox.text = "*Gasp* it was all just a dream.";
        restartButtonTrigger.enabled = false;
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.X)){
            MainCharacter.S.Scene7ChatCount++;
            UpdateDialogue();
        }
        if(MainCharacter.S.Scene7ChatCount >= 9){
            restartButtonTrigger.enabled = true;
        }
    }

    private void UpdateDialogue(){
        if(SceneManager.GetActiveScene().name == "__Scene_7_Awake"){
            switch (MainCharacter.S.Scene7ChatCount){
                case 1:
                    chatBox.text = "I remember the spell—the cats spell—that brought down the Mushroom Enchantress.";
                    break;
                case 2:
                    chatBox.text = "Her power shattered, her curse lifted, and for a moment, I thought I had saved something. But now…";
                    break;
                case 3:
                    chatBox.text = "nothing";
                    break;
                case 4:
                    chatBox.text = "It was never real.";
                    break;
                case 5:
                    chatBox.text = "All the danger, the magic, the victory—it was all in my head.";
                    break;
                case 6:
                    chatBox.text = "Why did it feel so real? Why do I still feel the burn of the spell in my veins?";
                    break;
                case 7:
                    chatBox.text = "What was the point of any of it, if it was just an illusion?";
                    break;
                case 8:
                    chatBox.text = "I'm still here, still searching for something real.";
                    break;
                default:
                    chatBox.text = "";
                    break;
            }
        }
        else if(SceneManager.GetActiveScene().name == "__Scene_7_Death"){
            switch (MainCharacter.S.Scene7ChatCount){
                case 1:
                    chatBox.text = "It felt so real... her eyes, dark as shadows, watching me fade. The mushrooms—so alive, so suffocating.";
                    break;
                case 2:
                    chatBox.text = "I died, I swear it. I felt it.";
                    break;
                case 3:
                    chatBox.text = "But this... this is my room. I’m alive.";
                    break;
                case 4:
                    chatBox.text = "I can feel the warmth of the sheets, the sunlight peeking through the curtains.";
                    break;
                case 5:
                    chatBox.text = "It’s real. I’m here.";
                    break;
                case 6:
                    chatBox.text = "I felt the end, but now, I feel this... new breath.";
                    break;
                case 7:
                    chatBox.text = "Was it all just a dream? Or... maybe a second chance?";
                    break;
                case 8:
                    chatBox.text = "Maybe it’s not over after all. Maybe I get to try again.";
                    break;
                default:
                    chatBox.text = "";
                    break;
            }
        }
    }
}