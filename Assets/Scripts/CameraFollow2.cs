using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float FollowSpeed = 2f;
    public Transform target;
    public Vector2 maxPosition = new Vector2(10f, 28f);
    public Vector2 minPosition = new Vector2(10f, 26.1f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y,-10f);
        newPos.x = Mathf.Clamp(newPos.x, minPosition.x, maxPosition.x);
        newPos.y = Mathf.Clamp(newPos.y, minPosition.y, maxPosition.y);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
        
    }
}
