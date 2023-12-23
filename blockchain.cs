
using System.Text; 
using System.Security.Cryptography;
using System.Runtime.Intrinsics.Arm;

///<Summary>Заметка для блокнота, который работает на блокчейне</Summary>

class Notes 
{ 
    public static string Splitter = "_splitter_"; 
    private string text; 
    private byte[] hash; 

    public Notes(string text) { 
        this.text = text; 
        this.hash = ComputeHash(text); 
    }  

    public byte[] ComputeHash(string text) { 
        SHA256 sHA = SHA256.Create(); 
        byte [] textBytes = Encoding.Default.GetBytes(text); 

        return sHA.ComputeHash(textBytes); 
    } 

    public string Text { get {return this.text; }} 
    
    public string ClearText { 
        get { 
            return this.text.Remove(0, this.text.IndexOf(Notes.Splitter)+ Notes.Splitter.Length); 
        }
    } 

    public string Hashstr { 
        get { 
            var hash = ComputeHash(this.text); 
            return Encoding.Default.GetString(hash); 

        }
    } 

    public byte [] Hash { get { return this.hash; }}

}