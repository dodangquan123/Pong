using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rigidBody;
    public float speed = 10;

    private void Awake(){
        rigidBody = GetComponent<Rigidbody2D>();
    }
    
    public void ResetPosition(){
        rigidBody.position = new Vector2(rigidBody.position.x, 0);
        rigidBody.velocity = Vector3.zero;
    }
}
