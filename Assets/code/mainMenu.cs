using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void startGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    // Update is called once per frame
    public void endGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif   
        Application.Quit();
    }
}
