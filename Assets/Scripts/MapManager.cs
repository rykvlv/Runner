using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : Singleton<MapManager>
{
    [SerializeField] private List<GameObject> platforms;
    [SerializeField] private float platformLength = 30f;
    [SerializeField] private float platformsMoveSpeed = 0.5f;

    private List<GameObject> _instantiatedPlatforms = new List<GameObject>();


    private void Start()
    {
        float z = 0f;
        foreach (GameObject platform in platforms)
        {
            GameObject newPlatform = Instantiate(platform, new Vector3(0f, 0f, z), Quaternion.identity);
            _instantiatedPlatforms.Add(newPlatform);
            z += platformLength;
        }
    }

    private void FixedUpdate()
    {
        
    }

    public void MoveMap()
    {
        for (int i = 0; i < _instantiatedPlatforms.Count; i++)
        {
            _instantiatedPlatforms[i].transform.Translate(new Vector3(0f, 0f, -platformsMoveSpeed), Space.World);
            if (_instantiatedPlatforms[i].transform.position.z < -60f)
            {
                GameObject tempPlatform;
                tempPlatform = _instantiatedPlatforms[0];
                _instantiatedPlatforms.RemoveAt(0);
                _instantiatedPlatforms.Add(tempPlatform);
                _instantiatedPlatforms[_instantiatedPlatforms.Count - 1].transform.position =
                    new Vector3(0f, 0f, _instantiatedPlatforms[_instantiatedPlatforms.Count - 2].transform.position.z + platformLength);
            }
        }
    }
}
