using UnityEngine;
using UnityEngine.Playables;

public class timeline1trigger : MonoBehaviour
{
    public PlayableDirector timeline;

    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();
    }

}
