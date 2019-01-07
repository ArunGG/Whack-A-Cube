using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour {

    private SpawnCube spawnCube;



	void Start ()
    {

        spawnCube = GameObject.Find("GameManager").GetComponent<SpawnCube>();
		
	}
	
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Cube")
        {
            spawnCube.anim["cubeAnimation"].enabled = false;
            //Debug.Log("GameOver");
            Destroy(collision.collider.gameObject);
            spawnCube.score.SetText("GAME OVER!");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }

}
