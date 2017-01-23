# Xamarin-Android-Link-Handler

Hello Everyone!

## ExtendedLinkMovementMethod
A movement method that extends system `LinkMovementMethod` and gives possibility to handle different link to an event from `TextView` element.

You can easily handle different type of urls by substring of URL.
    
    var extendedLinkMovementMethod = new ExtendedLinkMovementMethod(new string[] { "http" });
    extendedLinkMovementMethod.LinkClicked += OnLinkClicked;
    textView.MovementMethod = extendedLinkMovementMethod;
    
and raise when a pointer is released and at least one substring contains in URL.

![alt tag](https://nxphaw-bn1305.files.1drv.com/y3mnRGEhxCxYz-Zw9uf1iEm58MRf3-04CFi8QcRQEc9yCcAHcA2XqQDUolG9mtcO4TfgCEbsywjw--jgUcjcMlsMKS3AuJcTnGC4S1KE7gJUZLf91k4VnQwdXkTj8oppRwDRbKJ_S1t7Jur-QKeBoEM-qfEuTJbZFLEcdQzo7NM7x0?width=416&height=736&cropmode=none)
