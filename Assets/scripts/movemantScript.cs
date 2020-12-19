using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemantScript : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _jumpForce;

    [SerializeField]
    private Rigidbody _objectBody;

    private float _jumpRayLangth;
    // Start is called before the first frame update
    void Start()
    {
        _jumpRayLangth = transform.localScale.y / 2 + 0.1f;
    }

    void FixedUpdate() {
        float forward = Input.GetAxisRaw("Vertical");
        float right = Input.GetAxisRaw("Horizontal");
        _objectBody.AddForce(new Vector3(right,0,forward) * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space) && Physics.Raycast(transform.position, Vector3.down, _jumpRayLangth))
        {
            _objectBody.AddForce(Vector3.up * _jumpForce);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
          /* if (Input.GetKey(KeyCode.W))
        {
            _objectBody.AddForce(Vector3.forward * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _objectBody.AddForce(Vector3.right * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _objectBody.AddForce(Vector3.left * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _objectBody.AddForce(Vector3.back * _speed * Time.deltaTime);
        }*/
    }
}
