using Unity.VisualScripting;
using UnityEngine;

public class Basics : MonoBehaviour
{
    public float vel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += vel * Vector3.right * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += vel * Vector3.left * Time.deltaTime;
        }
    }
}
