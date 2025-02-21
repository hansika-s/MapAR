using UnityEngine;

public class InfoBehavior : MonoBehaviour
{

    const float Speed = 6f;

    [SerializeField]
    Transform InfoSection;

    Vector3 desiredScale = Vector3.zero;

    void Update()
    {
        InfoSection.localScale = Vector3.Lerp(InfoSection.localScale, desiredScale, Time.deltaTime * Speed);
    }

    public void OpenInfo()
    {
        desiredScale = new Vector3(3, 3, 1);
    }

    public void CloseInfo()
    {
        desiredScale = Vector3.zero;
    }
}
