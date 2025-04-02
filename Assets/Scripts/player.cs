using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody wasdRb;
    private float Work_range = 0.1f;

    public float walk_speed = 1.0f;
    public GameObject tama;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("wasd �őO�㍶�E�ړ�");
        wasdRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //wasd �ł��邭
        //if (Input.GetKey(KeyCode.W))  //�uW�v��������O�ɐi��
        //{
        //    wasdRb.AddForce(Vector3.forward * walk_speed );
        //}
        //if (Input.GetKey(KeyCode.A))  //�uA�v�������獶�ɐi��
        //{
        //    wasdRb.AddForce(Vector3.left * walk_speed );
        //}
        //if (Input.GetKey(KeyCode.S))  //�uS�v����������ɐi��
        //{
        //    wasdRb.AddForce(Vector3.back * walk_speed );
        //}
        //if (Input.GetKey(KeyCode.D))  //�uD�v��������E�ɐi��
        //{
        //    wasdRb.AddForce(Vector3.right * walk_speed );
        //}
        //wasd �ł��邭
        if (Input.GetKey(KeyCode.W))  //�uW�v��������O�ɐi��
        {
            transform.position = transform.position + (Vector3.forward * Work_range);
        }
        if (Input.GetKey(KeyCode.A))  //�uA�v�������獶�ɐi��
        {
            transform.position = transform.position + (Vector3.left * Work_range);
        }
        if (Input.GetKey(KeyCode.S))  //�uS�v����������ɐi��
        {
            transform.position = transform.position + (Vector3.back * Work_range);
        }
        if (Input.GetKey(KeyCode.D))  //�uD�v��������E�ɐi��
        {
            transform.position = transform.position + (Vector3.right * Work_range);
        }

        wasdRb.linearVelocity = Vector3.zero;
        wasdRb.angularVelocity = Vector3.zero;

    }
}

