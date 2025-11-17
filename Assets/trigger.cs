using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeline : MonoBehaviour
{
    public PlayableDirector timeline;

    void OnTriggerEnter(Collider other)
    {
        timeline.Play();
    }

}
