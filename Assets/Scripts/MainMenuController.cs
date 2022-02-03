using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        int selectedCharacter = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        GameManager.instance.CharIndex = selectedCharacter;
        SceneManager.LoadScene("Gameplay");

    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
