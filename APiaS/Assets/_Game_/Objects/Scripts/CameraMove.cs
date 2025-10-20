using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject CamLocate;
    private Camera cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter(Collider oth)
    {
        Vector2 camPos = CamLocate.transform.position;
        cam.transform.position = camPos;
    }
    void Start()
    {
        GameObject cam = GameObject.Find("MainCamera");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
