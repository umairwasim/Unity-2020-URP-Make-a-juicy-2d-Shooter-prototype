using DG.Tweening;
using UnityEngine;

public class ShakeFeedback : Feedback
{
    [SerializeField]
    private GameObject objectToShake;
    [SerializeField]
    private float duration = 0.2f, strength = 1, randomness = 90;
    [SerializeField]
    private readonly int vibrato = 10;
    private readonly bool snapping = false;
    private readonly bool fadeout = true;

    public override void CompletePreviousFeedback()
    {
        objectToShake.transform.DOComplete();
    }

    public override void CreateFeedback()
    {
        CompletePreviousFeedback();
        objectToShake.transform.DOShakePosition(duration, strength, vibrato, randomness, snapping, fadeout);
    }
}
