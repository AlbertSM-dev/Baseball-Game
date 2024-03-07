public class Solution {
    public int CalPoints(string[] operations) {
        int sum = 0;
        List<int> record = new List<int>();

        for(int i = 0; i < operations.Length; i++)
        {
            if (int.TryParse(operations[i], out sum)) 
            {
                record.Add(sum);                           
            }
            else if(operations[i] == "+")
            {                           
                record.Add(record[record.Count - 1] + record[record.Count - 2]);
            }
            else if(operations[i] == "C")
            {
                record.RemoveAt(record.Count - 1);
            }
            else if(operations[i] == "D")
            {
                record.Add((record[record.Count - 1]));
                record[record.Count - 1] *= 2;
            }                
        }
        return record.Sum();       
    }
}
