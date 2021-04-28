using System.Collections;
using UnityEngine;   
    public class Player : MonoBehaviour
{
    public float RotationSpeed = 120;

    private float CurrentRotationSpeedX = 0;
    private float CurrentRotationSpeedY = 0;

    private Rigidbody m_rigidbody;


    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            CurrentRotationSpeedX = Mathf.Lerp(CurrentRotationSpeedX, -RotationSpeed, Time.deltaTime * 3);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            CurrentRotationSpeedX = Mathf.Lerp(CurrentRotationSpeedX, RotationSpeed, Time.deltaTime * 3);
        }
        else
        {
            CurrentRotationSpeedX = Mathf.Lerp(CurrentRotationSpeedX, 0, Time.deltaTime * 4);
        }

        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            CurrentRotationSpeedY = Mathf.Lerp(CurrentRotationSpeedY, -RotationSpeed * sign, Time.deltaTime * 3);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            CurrentRotationSpeedY = Mathf.Lerp(CurrentRotationSpeedY, RotationSpeed * sign, Time.deltaTime * 3);
        }
        else
        {
            CurrentRotationSpeedY = Mathf.Lerp(CurrentRotationSpeedY, 0, Time.deltaTime * 4);
        }

        transform.RotateAround(transform.position, transform.right, CurrentRotationSpeedX * Time.deltaTime);
        transform.RotateAround(transform.position, Vector3.up, CurrentRotationSpeedY * Time.deltaTime);
    }
}
