using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{
    // Player's movement parameters
    public Vector3 direction;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    // OnPlayerMove event handler
    public void OnPlayerMove(InputValue value)
    {
        // A vector with x and y componenets corresponding to the player's WASD and arrow inputs
        // boht components are in the range [-1, 1]
        Vector2 inputVector = value.Get<Vector2>();
        direction = new Vector3(inputVector.x, 0, inputVector.y);

        //move in the XZ plane
        direction.x = inputVector.x;
        direction.z = inputVector.y;
    }
}
