using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Vector3 direction;
    public float speed;
    GameObject spawnPoint;
    public float addSpeed;
    void Start()
    {
        direction = Vector3.forward;
        spawnPoint = GameObject.Find("SpawnerPoint");
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)){
            
            if (direction.x == 0)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }
            speed += addSpeed * Time.deltaTime;
        }
        
        
    }
    private void FixedUpdate()
    {
        Vector3 movement = direction * Time.deltaTime *speed;
        transform.position += movement;
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("place"))
        {
            Score.score++;
            //collision.gameObject.AddComponent<Rigidbody>();
            spawnPoint.GetComponent<SpawnerPoint>().CubeCreate();
            StartCoroutine(PlaceClear(collision.gameObject));
            
        }
    }
    IEnumerator PlaceClear(GameObject ClearPlace)
    {
        yield return new WaitForSeconds(3f);
        Destroy(ClearPlace);
    }

    
    
}
