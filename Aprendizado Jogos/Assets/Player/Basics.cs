using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Basics : MonoBehaviour
{
    public float vel;
    public float jump;
    public Rigidbody2D rb2;

    public UnityEngine.SceneManagement.Scene actual;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        actual = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += vel * Vector3.right * Time.deltaTime;
            transform.rotation = new Quaternion(0,0,0,1);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position += vel * Vector3.left * Time.deltaTime;
            transform.rotation = new Quaternion(0,-180,0,1);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2.AddForce(transform.up * jump, ForceMode2D.Impulse);
        }

        if (rb2.position.y <= -5)
        {
            SceneManager.LoadScene(actual.name);
        }
    }
}
