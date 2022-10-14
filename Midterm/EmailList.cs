using System.Collections.Generic;
using System;

public class EmailList
{
    private List<Email> emailList;
    public EmailList()
    {
        this.emailList = new List<Email>();
    }
    public void AddNewEmail(Email emails)
    {
        this.emailList.Add(emails);
    }
    public string CheckEmail(string email,string password)
    {
        string n = "0";
        foreach (Email emails in this.emailList)
        {
            string Emails = email;
            string Passwords = password;
            if(Emails == emails.GetEmail() || Passwords == emails.GetPassword() || Emails == "exit")
            {
                if(Emails == "exit")
                {
                    n = "Back";
                    return n;
                }
                else 
                {
                n = "Again";
                return n;
                }
            }            
        }
        return n;
    }
}
