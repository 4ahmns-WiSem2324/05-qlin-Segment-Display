using System.Collections;
using UnityEngine;

public class CreateDigitScript : MonoBehaviour
{
    private bool[] segmentZeroToSetAcive = new bool[7] { true, true, true, true, true, true, false };
    private bool[] segmentOneToSetAcive = new bool[7] { false, true, true, false, false, false, false };
    private bool[] segmentTwoToSetAcive = new bool[7] { true, true, false, true, true, false, true };
    private bool[] segmentThreeToSetAcive = new bool[7] { true, true, true, true, false, false, true };
    private bool[] segmentFourToSetAcive = new bool[7] { false, true, true, false, false, true, true };
    private bool[] segmentFiveToSetAcive = new bool[7] { true, false, true, true, false, true, true };
    private bool[] segmentSixToSetAcive = new bool[7] { true, false, true, true, true, true, true };
    private bool[] segmentSevenToSetAcive = new bool[7] { true, true, true, false, false, false, false };
    private bool[] segmentEightToSetAcive = new bool[7] { true, true, true, true, true, true, true };
    private bool[] segmentNineToSetAcive = new bool[7] { true, true, true, true, false, true, true };
    public GameObject[] segments = new GameObject[7];
    public GameObject[] animatedSegments = new GameObject[7];
    public GameObject[] animNumbers = new GameObject[28];
    public int currentNumber;
    public AudioSource audioSource;
    public AudioClip clip;
    public int volume;

    public void ShowNumber(int a)
    {
        currentNumber = a;

        if (currentNumber == 0)
        {
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i].SetActive(segmentZeroToSetAcive[i]);
            }
        }

        if (currentNumber == 1)
        {
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i].SetActive(segmentOneToSetAcive[i]);
            }
        }

        if (currentNumber == 2)
        {
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i].SetActive(segmentTwoToSetAcive[i]);
            }
        }

        if (currentNumber == 3)
        {
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i].SetActive(segmentThreeToSetAcive[i]);
            }
        }

        if (currentNumber == 4)
        {
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i].SetActive(segmentFourToSetAcive[i]);
            }
        }

        if (currentNumber == 5)
        {
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i].SetActive(segmentFiveToSetAcive[i]);
            }
        }

        if (currentNumber == 6)
        {
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i].SetActive(segmentSixToSetAcive[i]);
            }
        }

        if (currentNumber == 7)
        {
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i].SetActive(segmentSevenToSetAcive[i]);
            }
        }

        if (currentNumber == 8)
        {
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i].SetActive(segmentEightToSetAcive[i]);
            }
        }

        if (currentNumber == 9)
        {
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i].SetActive(segmentNineToSetAcive[i]);
            }
        }
    }

    public void AnimateSegments()
    {
        StartCoroutine(AnimateNumber());
    }

    public void NumberAnimation()
    {
        StartCoroutine(Animation());
    }

    IEnumerator AnimateNumber()
    {
        for (int i = 0; i < animatedSegments.Length; i++)
        {
            animatedSegments[i].SetActive(false);
        }

        yield return new WaitForSeconds(1);

        foreach(GameObject segment in animatedSegments)
        {
            yield return new WaitForSecondsRealtime(0.5f);
            segment.SetActive(true);
            audioSource.PlayOneShot(clip, volume);
        }
    }

    IEnumerator Animation()
    {

        foreach (GameObject segment in animNumbers)
        {
            yield return new WaitForSecondsRealtime(0.5f);
            audioSource.PlayOneShot(clip, volume);
            segment.SetActive(true);
        }

        yield return new WaitForSeconds(1f);

        audioSource.PlayOneShot(clip, volume);

        for (int i = 0; i < animNumbers.Length; i++)
        {
            animNumbers[i].SetActive(false);
        }

    }

}
