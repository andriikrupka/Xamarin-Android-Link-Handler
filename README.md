# Xamarin-Android-Link-Handler

Hello Everyone!

## ExtendedLinkMovementMethod
A movement method that extends system `LinkMovementMethod` and gives possibility to handle different link to an event.

You can easily handle different type of urls by substring of URL.

    var extendedLinkMovementMethod = new ExtendedLinkMovementMethod(new string[] { "http" });
    extendedLinkMovementMethod.LinkClicked += OnLinkClicked;
    
and raise when a pointer is released and at least one substring contains in URL.
