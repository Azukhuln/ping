using UnityEngine;
using UnityEngine.SceneManagement; // added to help with new game manager menu using tools

public class HealthNet : MonoBehaviour
{
    [SerializeField]ball ballMovement;
    [SerializeField]healthCounter userHealth;
    [SerializeField]healthCounter botHealth;
    [SerializeField]string side; // tool assisted

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (side == "Player")
        {
            userHealth.UnitHealth--;
            Debug.Log($"Player health now: {userHealth.UnitHealth}");
            if(userHealth.UnitHealth <= 0)
            {
                if (GameManager.Instance != null)
                {
                    GameManager.Instance.GameOver();
                }
                else
                {
                    SceneManager.LoadScene("MainMenu");
                }
                return;
            }
        }
        else if (side == "bot")
        {
            botHealth.UnitHealth--;
            Debug.Log($"Bot health: {botHealth.UnitHealth}");
            if(botHealth.UnitHealth <= 0)
            {
                Debug.Log("Bot defeated! Calling LoadNextLevel()");
                if (GameManager.Instance != null)
                {
                    Debug.Log("GameManager exists, loading next level");
                    GameManager.Instance.LoadNextLevel();
                }
                else
                {
                    Debug.LogError("GameManager.Instance is NULL!");
                }
                return;
            }
        }
        ballMovement.transform.position = ballMovement.startPos;
        ballMovement.launch(); // this will cause player or bot to loose health and reset position.
    }

}
