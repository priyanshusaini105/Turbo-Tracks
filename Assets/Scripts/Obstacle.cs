using UnityEngine;

public class Obstacle:MonoBehaviour
{
    private GameController gameController;
    void Start(){
        gameController=FindObjectOfType<GameController>();
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player")
        {
            gameController.GameOver();
        }
    }

}