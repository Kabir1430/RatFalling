using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Script")]

    public Spawn Spawn;

    [Header("Movement")]
    [SerializeField] public float speed = 5f;
    [SerializeField] public Rigidbody rb;

        [Header("Joystick")]
    public DynamicJoystick joystick;


    [Header("Spawn")]
    public bool Spawned;
    [SerializeField] GameObject groundTile;
    Vector3 nextSpawnPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
       
    

        MovePlayer();

    }

    void MovePlayer()
    {
        float horizontalInput = joystick.Horizontal;

        float verticalInput = joystick.Vertical ;

        Vector3 inputDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        Vector3 velocity = inputDirection * speed;

        // Apply smoothing to the movement
        Vector3 smoothVelocity = Vector3.Lerp(rb.velocity, velocity, 0.1f);
        rb.velocity = new Vector3(smoothVelocity.x, rb.velocity.y, smoothVelocity.z);
    }



    private void OnTriggerEnter(Collider other)
    {
      
        if(other.tag=="Detect")
        {


            if(Spawned)
            {

           SpawnTile();
                Spawned = false;
            }



        }
    }
  


    


    // Start is called before the first frame update

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

    }
}