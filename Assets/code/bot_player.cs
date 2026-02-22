using UnityEngine;
using UnityEngine.SceneManagement;

public class bot_player : MonoBehaviour
{
    [SerializeField]GameObject Ball;

    //[SerializeField] float reactionTime = 0.2f; // Lower = harder

    Rigidbody2D rb;

    string sceneName;

    float speed = 2;

    //float reactionTimer;
    float targetY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sceneName = SceneManager.GetActiveScene().name;
        setDifficulty();
        //setSkill(speed); //set the bot ability/skill example ideas phantom ball, stop player, ect.
    }

    // Update is called once per frame
    void setDifficulty()
    {
        if (sceneName == "Level 1") { speed = 2.75f; }
    else if (sceneName == "Level 2") { speed = 3f; }
    else if (sceneName == "Level 3") { speed = 3.5f; }
    else if (sceneName == "Level 4") { speed = 4.25f; }
    else if (sceneName == "Level 5") { speed = 5f; }
    }

    void MoveTowardTarget()
    {
        if (targetY > transform.position.y)
            rb.linearVelocity = new Vector2(0, speed);
        else if (targetY < transform.position.y)
            rb.linearVelocity = new Vector2(0, -speed);
        else
            rb.linearVelocity = Vector2.zero;
    }

    
    void Update()
    {
        if(Ball.transform.position.y > transform.position.y)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, speed);
        }
        else if (Ball.transform.position.y < transform.position.y)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -speed);
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
    
    // difficulty options based on the bot should be added
    // add bot abilities
    // bot does not move after hitting ball and only moves when its coming back at it (maybe we have it not move when ball dissapears via player ability)
    /*void setskill(float speed)
    {
        if (speed == 2.75f){}
        else if (speed == 3f){}
        else if (speed == 3.5f){}
        else if (speed == 4.25f){}
        else if (speed == 5f){}
    }*/
}
