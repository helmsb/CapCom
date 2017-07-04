using System;
interface IChatProvider
{
    /// <summary>
    /// The name of the chat provider. This would be displayed in administration panels.
    /// </summary>
    /// <example>FlowDock-Provider</example>
    /// <returns>String</returns>
    string Name {get; set;}

    /// <summary>
    /// Description of the chat provider. This would be displayed in administration panels.
    /// </summary>
    /// <example>Provides both monitoring and posting of Flowdock flows</example>
    /// <returns>String</returns>
    string Description {get; set;}

    /// <summary>
    /// The name of the icon you would like to show in the administration panel. Note this must be placed in the "images" 
    /// directory of your extension. 
    /// </summary>
    /// <returns>String</returns>
    string IconName { get; set; }

    /// <summary>
    /// /// The URI to your chat platform.
    /// </summary>
    /// <returns></returns>
    Uri ChatPlatformUri { get; set; }

    /// <summary>
    /// A boolean to tell CapCom if the client is trying to use your chat provider with an unsupported version of the chat platform
    /// </summary>
    /// <returns>Bool</returns>
    bool IsSupportedChatPlatformVersion();

    /// <summary>
    /// This is called whenever your chat platform provider is first invoked. Return a bool indicating whether or not you are
    /// successful.
    /// </summary>
    /// <returns>Bool based on initialization success</returns>
    bool InitalizeChatPlatform();

    /// <summary>
    /// Used to post messages to the chat provider. It returns a bool to let the system know if it was successful
    /// </summary>
    /// <param name="chatPost"></param>
    /// <returns>bool</returns>
    bool PostNewMessage(IChatPost chatPost);

}