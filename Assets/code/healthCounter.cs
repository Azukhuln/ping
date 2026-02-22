using UnityEngine;
using TMPro;
public class healthCounter : MonoBehaviour
{
    TextMeshProUGUI textmesh;

    public int unitHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textmesh.text = unitHealth.ToString();
    }
}
