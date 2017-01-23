# Xamarin-Android-Link-Handler

Hello Everyone!

## ExtendedLinkMovementMethod
A movement method that extends system `LinkMovementMethod` and gives possibility to handle different link to an event from `TextView` element.

You can easily handle different type of urls by substring of URL.
    
    var extendedLinkMovementMethod = new ExtendedLinkMovementMethod(new string[] { "http" });
    extendedLinkMovementMethod.LinkClicked += OnLinkClicked;
    textView.MovementMethod = extendedLinkMovementMethod;
    
and raise when a pointer is released and at least one substring contains in URL.

![alt tag](https://github.com/andriikrupka/Xamarin-Android-Link-Handler/blob/master/ExtendedLinkMovementMethodReadme.gif?raw=true)
