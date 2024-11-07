using System.Collections;

public class Stack{
    public List<string> ls = new List<string>();
   
    public void Push(string item){
        ls.Add(item);
    }

    public string Pop(){
        var item = ls.LastOrDefault();
        if(item != null)
        {
            ls.Remove(item);
            return item;
        }
        return null;
    }

    public void Print(){
        foreach (var item in ls){
            System.Console.WriteLine(item);
        }
    }
}