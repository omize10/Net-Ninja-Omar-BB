using UnityEngine;
using UnityEngine.UI;

public class ButtonImageChanger : MonoBehaviour
{
    public Sprite ballImage;
    public Sprite ballSprite;

    private void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(ChangeBallImage);
        }
    }

    private void ChangeBallImage()
    {
        HoopManger2 HM2 = GameObject.Find("WorkingBall").GetComponent<HoopManger2>();
        if (HM2 != null)
        {
            HM2.ChangeBallImage(ballImage);
        }
    }



public void OnButtonPress()
{
    GameObject ballObject = GameObject.FindGameObjectWithTag("Ball");
    if (ballObject != null)
    {
        SpriteRenderer ballRenderer = ballObject.GetComponent<SpriteRenderer>();
        if (ballRenderer != null)
        {
            ballRenderer.sprite = ballSprite; // Assign the selected sprite to the ball
        }
    }
}

}
