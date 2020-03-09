using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelUI : MonoBehaviour {

    public Text AnnouncerTextLine1;
    public Text AnnouncerTextLine2;
    public Text LevelTimer;

    public Slider[] healthSliders;

    public GameObject[] winIndicatorGrids;
    public GameObject winIndicator;

    public static LevelUI instance;
    void Awake()
    {//Check if instance already exists
        if (instance == null)
        {
            //if not, set instance to this
            instance = this;
        }
        //If instance already exists and it's not this:
        else if (instance != this)
        {
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        }
    }
    public static LevelUI GetInstance()
    {
        return instance;
    }


    public void AddWinIndicator(int player)
    {
        GameObject go = Instantiate(winIndicator, transform.position, Quaternion.identity) as GameObject;
        go.transform.SetParent(winIndicatorGrids[player].transform);
    }
}
