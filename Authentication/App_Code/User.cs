﻿using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    private string email;
    private string password;
    private string salt;
    public User()
    {

        //
        // TODO: Add constructor logic here
        //
    
    }

    public string Email
    {
        get
        {
            return email;
        }

        set
        {
            email = value;
        }
    }

    public string Password
    {
        get
        {
            return password;
        }

        set
        {
            password = value;
        }
    }

    public string Salt
    {
        get
        {
            return salt;
        }

        set
        {
            salt = value;
        }
    }
}