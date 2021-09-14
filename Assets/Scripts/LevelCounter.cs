using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCounter : MonoBehaviour
{
    private static int level = 0;
    Text levelLabel;

    // Start is called before the first frame update
    void Start()
    {
        levelLabel = GetComponent<Text>();
        incrementLevelCount();
        levelLabel.text = "Level " + level.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void incrementLevelCount()
    {
        level++;
    }

    public static void resetLevelCount()
    {
        level = 0;
    }
}
