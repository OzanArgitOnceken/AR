using EasyJoystick;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Joystick joystick;


    // Update is called once per frame
    void Update()
    {
        float xMov = joystick.Horizontal();
        float zMov = joystick.Vertical();
        transform.position += new Vector3(xMov,zMov, 0f) * speed * Time.deltaTime;
    }
}
