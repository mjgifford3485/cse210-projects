using System;
using System.Collections.Generic;

public class GuidedImageryActivity : Activity
{
    private List<string> _image;
    public GuidedImageryActivity(string name, string description, int duration, List<string> image) : base(name, description, duration)
    {
        _image = new List<string>(image);
    }
    public void Run()
    {
        DisplayStartingMessage(); 
        ShowSpinner(3);
        Console.WriteLine("Spend the next {_duration} trying to picture the image below: ");
        DisplayImage();
        ShowCountDown(_duration);
        DisplayEndingMessage();
    }
    public void DisplayImage()
    {
        Random randomImage = new Random();
        int index = randomImage.Next(_image.Count);
        Console.WriteLine(_image[index]);
    }

}