using UnityEngine;
using TMPro;
public class healthCounter : MonoBehaviour
{
    TextMeshProUGUI textmesh;
    [SerializeField] private int punitHealth = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int UnitHealth
    {
        get{return punitHealth;}
        set
        {
            punitHealth = value;
            UpdateHealthDisplay();
        }
    }

    void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
        UpdateHealthDisplay();
    }

    // Update is called once per frame
    void UpdateHealthDisplay()
    {
        if(textmesh != null)
        {
            textmesh.text = punitHealth.ToString();
        }
    }
    public void SetHealth(int value)
    {
        UnitHealth = value;
    }
}
