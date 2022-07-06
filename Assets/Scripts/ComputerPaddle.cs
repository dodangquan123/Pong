using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    private void FixedUpdate(){
        if (this.ball.velocity.x > 0){
            if (this.ball.velocity.y > this.transform.position.y){
                rigidBody.AddForce(Vector2.up * speed);
            }
            else if (this.ball.velocity.y < this.transform.position.y){
                rigidBody.AddForce(Vector2.down * speed);
            }
        }
        else{
            if (this.transform.position.y < 0){
                rigidBody.AddForce(Vector2.up * speed);
            }
            else if (this.transform.position.y > 0){
                rigidBody.AddForce(Vector2.down * speed);
            }
        }
    }
}
