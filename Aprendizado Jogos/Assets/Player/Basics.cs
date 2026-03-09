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
            transform.rotation = new Quaternion(0,0,0,1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += vel * Vector3.left * Time.deltaTime;
            transform.rotation = new Quaternion(0,-180,0,1);
        }
    }
}
