using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200;
    private Rigidbody2D rigidBody;

    private void Awake(){
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void Start(){
        AddStartingForce();
    }

    private void AddStartingForce(){
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        rigidBody.AddForce(direction * speed);
    }
}
