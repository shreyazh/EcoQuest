using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class playerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private float speed;
    float speedX, speedY;
    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up") && !(Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right"))) {
            speedY = speed;
            anim.SetInteger("direction", 1);
        }
        else if(Input.GetKey("down") && !(Input.GetKey("up") || Input.GetKey("left") || Input.GetKey("right"))) {
            speedY = -speed;
            anim.SetInteger("direction", 3);
        }
        else {
            speedY = 0;
        }

        if(Input.GetKey("left") && !(Input.GetKey("down") || Input.GetKey("up") || Input.GetKey("right"))) {
            speedX = -speed;
            anim.SetInteger("direction", 2);
        }
        else if(Input.GetKey("right") && !(Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("up"))) {
            speedX = speed;
            anim.SetInteger("direction", 0);
        }
        else {
            speedX = 0;
        }

        if(speedX != 0 || speedY != 0) {
            anim.SetBool("running", true);
        } else {
            anim.SetBool("running", false);
        }

        rb.linearVelocity = new Vector2(speedX, speedY);
        
        if(speedX > 0) {
        }
        if(speedX < 0) {
        }
        if(speedY > 0) {
        }
        if(speedY < 0) {
        }
    }
}
