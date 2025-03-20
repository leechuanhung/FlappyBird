
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{ 
    void Start()
    {
        GetComponent<Text>().text = "Best Score : " + Score.bestscore;
    }

}
