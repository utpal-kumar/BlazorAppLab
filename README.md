This project is created to practice Groq AI API in blazor C# application.

Befor running the app open the page AskGroq.razor under Component/Pages and use your Groq API Key, creating Groq API is very easy. 

Login to https://console.groq.com/ and create Key from /keys page then store the API Key and use the API key in "AskGroq.razor" page 

and use it the the linerequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "Groq AI API Key"); in place Bearer token "Groq AI API Key".
