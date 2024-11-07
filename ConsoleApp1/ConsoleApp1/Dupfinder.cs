//input : xyzzy
//ouput: xyz

using System.Collections;

public class DupRemover{

    public List<string> Remove(List<string> input)
    {
        //var lst = new List<char>();
        var dict = new Dictionary<string, string>();

        foreach(var item in input)
        {
            if(!dict.ContainsKey(item))
            {
                dict.Add(item, item);
            }
        }
        return dict.Values.ToList();
    }
}