using UnityEngine;
using UnityEngine.SceneManagement;


public class ball : MonoBehaviour
{
    //public Rigidbody2D rb;
    float ballSpeed = 5;
    Rigidbody2D rb;
    public Vector2 startPos;

    string sceneName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

       startPos = transform.position;
       rb = GetComponent<Rigidbody2D>();
       sceneName = SceneManager.GetActiveScene().name;
       launch();
       setSpeed();

    }

    // Update is called once per frame
    public void launch()
    {
        int x = Random.Range(0,2);
        int y = Random.Range(0,2);

        if (x == 0){
            x = -1;
        }
        if (y == 0){
            y = -1;
        }

        rb.linearVelocity = new Vector2(x * ballSpeed, y *ballSpeed);
    }
    
    public void setSpeed()
    {
        if (sceneName == "Level 1") { ballSpeed = 4.75f; }
        else if (sceneName == "Level 2") { ballSpeed = 4.90f; }
        else if (sceneName == "Level 3") { ballSpeed = 5.35f; }
        else if (sceneName == "Level 4") { ballSpeed = 5.85f; }
        else if (sceneName == "Level 5") { ballSpeed = 6.25f; }
        
    }
    // add ability modifiers

}
