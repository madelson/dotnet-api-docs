﻿using System;
using System.Data;
using System.Security.Principal;
using System.Windows.Forms;

public class Form1: Form
{
    protected void Method()
    {
        // <Snippet1>
        Uri baseUri = new Uri("http://www.contoso.com:8080/");
        Uri myUri = new Uri(baseUri, "shownew.htm?date=today");

        Console.WriteLine(myUri.Host);
        // </Snippet1>
    }
}