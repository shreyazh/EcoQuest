using UnityEngine;
using System.Collections;

public class CameraChange2 : MonoBehaviour
{
    private CameraFollow2 cam;
    public Transform player;
    private FadeInOut fade;

    void Start()
    {
        cam = Camera.main.GetComponent<CameraFollow2>();
        fade = FindObjectOfType<FadeInOut>();
    }

    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collidedObject)
    {
        switch (collidedObject.name)
        {
            case "toZone0":
                cam.minPosition = new Vector2(-7.6f, -10f);
                cam.maxPosition = new Vector2(34.1f, 4.1f);
                break;
            case "toZone1":
                cam.minPosition = new Vector2(51.8f, -23.2f);
                cam.maxPosition = new Vector2(110.8f, 8.3f);
                break;
            case "toHome":
                StartCoroutine(TeleportWithFade(new Vector2(11.58f, 22.28f), new Vector2(10f, 26.1f), new Vector2(10.8f, 28f)));
                break;
            case "toZone0FromHome":
                StartCoroutine(TeleportWithFade(new Vector2(0.39f, 1.7f), new Vector2(-7.6f, -10f), new Vector2(34.1f, 4.1f)));
                break;
            default:
                break;
        }
    }

    private IEnumerator TeleportWithFade(Vector2 playerTargetPosition, Vector2 minCamPos, Vector2 maxCamPos)
    {
        fade.FadeIn();
        yield return new WaitForSeconds(0.5f);

        // Perform teleportation and camera adjustments
        player.position = playerTargetPosition;
        cam.minPosition = minCamPos;
        cam.maxPosition = maxCamPos;

        yield return new WaitForSeconds(1f);

        fade.FadeOut();
    }
}
