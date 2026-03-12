using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject finalCanva;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        finalCanva.SetActive(true);
    }
}
