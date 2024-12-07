using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue6 : MonoBehaviour{

    [SerializeField] private TextMeshProUGUI chatBox;

    public float moveSpeed = 0.1f;

    void Update(){
        if (Input.GetKeyDown(KeyCode.X)){
            MainCharacter.S.Scene6ChatCount++;
            UpdateDialogue();
        }

        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    private void UpdateDialogue(){
        switch (MainCharacter.S.Scene6ChatCount){
            case 1:
                chatBox.text = "WHO ARE YOU?!";
                break;
            case 2:
                chatBox.text = "YOU ARE TRESSPASSING IN MY FOREST";
                break;
            case 3:
                chatBox.text = "You think you can defeat me? I am the fungi of nightmares, and you are but a fleeting dream!";
                break;
            case 4:
                chatBox.text = "For centuries, I have woven the threads of nature to my will, binding this cursed land to my very essence. And now, you come to challenge me? Pathetic!";
                break;
            case 5:
                chatBox.text = "My powers control the earth and its deepest secrets. The roots tremble to my command—let them take you!";
                break;
            case 6:
                chatBox.text = "You are but a small child. What are you even doing here?!";
                break;
            case 7:
                chatBox.text = "The spores I cast will twist your mind and body, binding you forever to the shadows of this forest. You will become one with the earth, just like the rest.";
                break;
            case 8:
                chatBox.text = "Your fate was sealed the moment you stepped into my realm. No one escapes the grasp of my spores.";
                break;
            case 9:
                chatBox.text = "The forest bends to my will. I am both its creator and its destroyer. And you? You are a mere speck, ready to be consumed.";
                break;
            case 10:
                chatBox.text = "My power is absolute, my magic invincible. There is nothing, not even you, that can undo what I have done.";
                break;
            default:
                chatBox.text = "I will twist you, reshape you, until you are but another part of my dark forest.";
                MainCharacter.S.Scene6ChatCount = 3;
                break;
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){ 
            Destroy(MainCharacter.S);

            Destroy(MainCharacter.S.gameObject);

            SceneManager.LoadScene("__Scene_7_Death");
        }
    }
}