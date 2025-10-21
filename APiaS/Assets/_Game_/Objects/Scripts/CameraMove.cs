using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject CamLocate;
    private Vector3 camPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter(Collider oth)
    {
        Debug.Log("Trigger entered by: " + oth.name);
        Camera.main.transform.position = camPos;
    }
    void Start()
    {
        camPos = CamLocate.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
