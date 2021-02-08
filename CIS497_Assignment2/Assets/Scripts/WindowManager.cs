//Found on UnityForums by user 'alvmoral'
//Creates an event that is invoked when the screen changes size. Used to help keep game boundries in place with screen resizing.
//URL: https://forum.unity.com/threads/window-resize-event.40253/
//Assigment 2
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public delegate void ScreenSizeChangeEventHandler(int Width, int Height);       //  Define a delgate for the event
    public event ScreenSizeChangeEventHandler ScreenSizeChangeEvent;                //  Define the Event
    protected virtual void OnScreenSizeChange(int Width, int Height)                //  Define Function trigger and protect the event for not null;
    {
        ScreenSizeChangeEvent?.Invoke(Width, Height);
    }
    private Vector2 lastScreenSize;
    public static WindowManager instance = null;                                    //  Singleton for call just one instance
    void Awake()
    {
        lastScreenSize = new Vector2(Screen.width, Screen.height);
        instance = this;                                                            // Singleton instance
    }
    void Update()
    {
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        if (this.lastScreenSize != screenSize)
        {
            this.lastScreenSize = screenSize;
            OnScreenSizeChange(Screen.width, Screen.height);                        //  Launch the event when the screen size change
        }
    }
}