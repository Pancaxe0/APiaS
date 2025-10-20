using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public float speed;
    [SerializeField] float speed2;
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // void DestroyCircle(GameObject ObjectTo)
    // {
    //     Destroy(ObjectTo);
    // }

    // Update is called once per frame
    void Update()
    {
        
        //movement
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 moveVector = new Vector2(x, y);
        transform.Translate(moveVector * speed * Time.deltaTime);
    
        //sprint
        // if (Input.GetKeyDown(KeyCode.LeftShift)){
        //     speed = 10;
        // }
        // if (Input.GetKeyUp(KeyCode.LeftShift))
        // {
        //     speed = 5;
        // }
    }
}


