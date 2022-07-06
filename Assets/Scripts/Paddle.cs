using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rigidBody;
    public float speed = 10;

    private void Awake(){
        rigidBody = GetComponent<Rigidbody2D>();
    }
}
