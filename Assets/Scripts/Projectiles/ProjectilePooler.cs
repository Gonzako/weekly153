using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePooler : MonoBehaviour
{

    [SerializeField] private GameObject _projectilePrefab = null;
    [SerializeField] private int _amount = 0;

    public static ProjectilePooler _instance;
    private List<GameObject> _pool = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        if(_instance != this)
        {
            _instance = this;
        }

        InstatiatePool();
    }

    private void InstatiatePool()
    {
        for(int x = 0; x < _amount; x++)
        {
            GameObject new_instance = Instantiate(_projectilePrefab);
            new_instance.SetActive(false);
            _pool.Add(new_instance);
        }
    }

    public GameObject getPooledObject()
    {
        for (int x = 0; x < _pool.Count; x++)
        {
            GameObject ob = _pool[x];
            if (!ob.activeInHierarchy)
            {
                ob.SetActive(true);
                return ob;
            }
        }

        return null;
    }

   
  
}
