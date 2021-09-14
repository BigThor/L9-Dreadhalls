using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnBelowHeight : MonoBehaviour
{
    public int heightToDespawn = 0;
    // Pass music so we can destroy it
    public GameObject objectToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        objectToDestroy = GameObject.Find("WhisperSource");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < heightToDespawn)
        {
            if (objectToDestroy != null)
                Destroy(objectToDestroy);
            SceneManager.LoadScene("Game Over");
            LevelCounter.resetLevelCount();
        }
    }
}
