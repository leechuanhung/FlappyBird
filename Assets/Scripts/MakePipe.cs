using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Pipe;
    public float TimeDiff;

    float timer = 0;

    void Start()
    {
        timer = TimeDiff;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > TimeDiff)
        {
            GameObject newPipe = Instantiate(Pipe);
            newPipe.transform.position = new Vector3(-1.22f, Random.Range(-0.38f, 4.04f), 0);
            timer = 0;
        }
    }
}
