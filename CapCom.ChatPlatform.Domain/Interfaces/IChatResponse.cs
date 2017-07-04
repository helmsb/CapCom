using System;
interface IChatResponse
{
    /// <summary>
    /// The name of the person who posted the triggered message.
    /// </summary>
    /// <returns></returns>
    string UserName{get;set;}

    /// <summary>
    /// Body of the message
    /// </summary>
    /// <returns></returns>
    string Message{get;set;}

    /// <summary>
    /// The date time that 
    /// </summary>
    /// <returns></returns>
    DateTime DateTimeReceived{get;set;}
}