using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    private string fileName= "Screenshot"+ System.DateTime.Now.Hour + System.DateTime.Now.Minute + System.DateTime.Now.Second + ".png";
    private string filePath;
    void Start()
    {
        filePath = Application.persistentDataPath + "/";
        if (!System.IO.Directory.Exists(filePath))
        {
            System.IO.Directory.CreateDirectory(filePath);
        }
    }

   public void ScreenShotFunction()
    {
        ScreenCapture.CaptureScreenshot(fileName);
        System.IO.File.Move(fileName, filePath);
    }
}
