using UnityEngine.UI;

public class PressButton : Button
{
    public bool PublicIsPressed()
    {
        return base.IsPressed();
    }
}