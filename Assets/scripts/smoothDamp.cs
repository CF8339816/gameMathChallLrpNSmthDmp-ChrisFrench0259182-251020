using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class smoothDamp : MonoBehaviour

{
    [SerializeField] Vector3 startPosition;
    [SerializeField] Vector3 targetPosition;
    [SerializeField] Vector3 endPosition;
    [SerializeField] float smoothTime = 0.5f;
    [SerializeField] float stoppingDistance = 0.1f;
    [SerializeField] Vector3 currentTarget;
    [SerializeField] Vector3 currentVelocity = Vector3.zero;
    void Start()
    {
        startPosition = transform.position;
        targetPosition = new Vector3(10, 0, 0);
        endPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Vector3.Distance(transform.position, currentTarget) < stoppingDistance)
        {
            // target switch for return trip check
            if (currentTarget == targetPosition)
            {
                currentTarget = startPosition; 
            }
            else
            {
                currentTarget = targetPosition; 
            }
        }

        transform.position = Vector3.SmoothDamp(transform.position, currentTarget, ref currentVelocity, smoothTime);


    }
}