using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Fist : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] Transform _transform;
    [SerializeField] BoxCollider2D _boxCollider;
    bool _triggered;
    float speed = 50;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _triggered = true;
        _audioSource.Play();
        _boxCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_triggered && _transform.position.y < -4.5)
        {
            _transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }
}
