using TMPro;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class lerp : MonoBehaviour
{
    [SerializeField] Vector3 startPosition;
    [SerializeField] Vector3 targetPosition;
    [SerializeField] Vector3 endPosition;
    [SerializeField] Vector3 currentTarget;

    [SerializeField] float moveDuration = 1.0f; // Time in seconds
    [SerializeField]  float elapsedTime;
     static bool movingToEnd = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        currentTarget = endPosition;

        //startPosition = transform.position;
        //targetPosition = new Vector3(10, 3, 0);
        //endPosition = new Vector3(0, 3, 0);

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        float t = elapsedTime / moveDuration;

       


        if (movingToEnd)
        {
            //target switch for return trip check
            if (currentTarget == targetPosition)
            {
                transform.position = Vector3.Lerp(startPosition, endPosition, t);
            }
            else
            {
                transform.position = Vector3.Lerp(endPosition, startPosition, t);
            }

            //if (currentTarget == targetPosition)
            //{
            //    currentTarget = startPosition;
            //}
            //else
            //{
            //    currentTarget = targetPosition;
            //}



        }
     
        transform.position = Vector3.Lerp(startPosition, endPosition, t);




    }




}
