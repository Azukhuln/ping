
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance{get; private set;}
    // this coding section for the GameManager is relying on deepseek for help setting everything up
    [SerializeField] private int currentLevel = 1;
    [SerializeField] private int totalLevels = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        //used to keep the manager alive between game scenes
        if (Instance == null)
        {
            Instance = this;

            transform.SetParent(null);

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    private void Start()
    {
        // gets the current level from the scene name
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName.Contains("Level"))
        {
            string levelNum = sceneName.Replace("Level ", "");
            int.TryParse(levelNum, out currentLevel);
        }
    }
    //loads the next mission or if player has beaten all levels it will go back to menu
    public void LoadNextLevel()
    {
        Debug.Log($"LoadNextLevel called. Current level: {currentLevel}, Total levels: {totalLevels}");
        currentLevel++;
        Debug.Log($"After increment: {currentLevel}");
        if (currentLevel <= totalLevels)
        {
            Debug.Log($"ABOUT TO LOAD: Level {currentLevel}");
            SceneManager.LoadScene("Level " + currentLevel);
        }
        else
        {
            ReturnToMenu();
        }
    }
    // this will take the player back to the main menu    
    public void GameOver()
    {
        Debug.Log("Game Over!");
        ReturnToMenu();
    }

    //this will reset the level and take user back to main menu scene
    public void ReturnToMenu()
    {
        currentLevel = 1;
        SceneManager.LoadScene("main menu");
    }

    public void ResetToLevelOne()
    {
        currentLevel = 1;
        Debug.Log("Game reset to Level 1");
    }

}
