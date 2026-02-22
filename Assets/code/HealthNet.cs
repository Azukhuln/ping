using UnityEngine;

public class HealthNet : MonoBehaviour
{
    [SerializeField]ball ballMovement;
    [SerializeField]healthCounter userHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        userHealth.unitHealth--;
        ballMovement.transform.position = ballMovement.startPos;
        ballMovement.launch(); // this will cause player or bot to loose health and reset position.
    }

}
