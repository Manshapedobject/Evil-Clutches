using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 4;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        { transform.Translate(transform.up * speed * Time.deltaTime); 
        }
    }
}
