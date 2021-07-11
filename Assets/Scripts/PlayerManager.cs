using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Singleton<PlayerManager>
{
    [SerializeField] private GameObject playerPrefab;

    private GameObject _currentPlayer;
    private Animator _animator;

    private void Start()
    {
        _currentPlayer = Instantiate(playerPrefab, new Vector3(0f, 0.5f, 7f), Quaternion.identity);
        _animator = _currentPlayer.GetComponent<Animator>();
        Debug.Log("Player instantiated");
        
    }

    public void Animate(string stateName)
    {
        _animator.Play(stateName);
    }

    public GameObject GetPlayer()
    {
        return _currentPlayer;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Debug.Log("zxc");
            Destroy(other.gameObject);
        }
    }
}
