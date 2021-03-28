/*****************************************************************************
// File Name :         Target.cs
// Author :            Kyle Grenier
// Creation Date :     03/28/2021
//
// Brief Description : Defines the behaviour for the in game target.
*****************************************************************************/
using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour
{
    [Tooltip("Where we'd like the target to end up")]
    [SerializeField] private Transform[] endPositions;

    private void Start()
    {
        StartCoroutine(UpdateMovement());
    }

    private IEnumerator Translate(Vector3 endPos)
    {
        Vector3 startPos = transform.localPosition;
        Vector3 finalPos = new Vector3(endPos.x, startPos.y, endPos.z);

        float movementSpeed = Random.Range(2f, 10f);

        float dist = Vector3.Distance(startPos, endPos);
        float distCovered = 0f;

        float counter = 0f;
        float fractionOfJourney = 0f;

        while(fractionOfJourney < 1f)
        {
            counter += Time.deltaTime;
            distCovered = counter * movementSpeed;
            fractionOfJourney = distCovered / dist;

            transform.localPosition = Vector3.Lerp(startPos, finalPos, fractionOfJourney);
            yield return null;
        }
    }

    private IEnumerator UpdateMovement()
    {
        Coroutine translationCoroutine = null;

        while(true)
        {
            if (translationCoroutine != null)
                StopCoroutine(translationCoroutine);

            Vector3 position = ArrayHelper.GetRandomElement(endPositions).position;
            translationCoroutine = StartCoroutine(Translate(position));

            yield return new WaitForSeconds(Random.Range(0f, 0.5f));
        }
    }
}