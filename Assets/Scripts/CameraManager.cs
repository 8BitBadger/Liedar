using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform target;
    public SpriteRenderer mapSR;

    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null) return;

        float camXBound = (float)(target.position.x + (cam.orthographicSize * Screen.width / Screen.height));
        float camYBound = (float)(target.position.y + cam.orthographicSize);
        float mapXBound = mapSR.bounds.size.x / 2;
        float mapYBound = mapSR.bounds.size.y / 2;

        float camNegXBound = (float)(target.position.x - (cam.orthographicSize * Screen.width / Screen.height));
        float camNegYBound = (float)(target.position.y - cam.orthographicSize);

        if (camXBound <= mapXBound && camNegXBound >= -mapXBound)
        {
            transform.position = Vector3.Lerp(
                new Vector3(transform.position.x, transform.position.y, -10),
                new Vector3(target.position.x, transform.position.y, -10), 0.1f);
        }

        if (camYBound <= mapYBound && camNegYBound >= -mapYBound)
        {
            transform.position = Vector3.Lerp(
                new Vector3(transform.position.x, transform.position.y, -10),
                new Vector3(transform.position.x, target.position.y, -10), 0.1f);
        }
    }

}
