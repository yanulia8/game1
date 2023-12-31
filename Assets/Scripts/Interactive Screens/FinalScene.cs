using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScene : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] CircleCollider2D _collider;
    [SerializeField] Rigidbody2D _playerRB;
    [SerializeField] Animator _animator;
    [SerializeField] FinalScreen _finalScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _audioSource.Play();
        gameObject.SetActive(false);
        _playerRB.bodyType = RigidbodyType2D.Static;
        _animator.SetBool("IsEnd", true);
        _finalScreen.SetUp();
    }
}
