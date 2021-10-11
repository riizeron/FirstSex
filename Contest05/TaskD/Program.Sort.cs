using System;

public partial class Program
{
    static bool ParseArrayFromLine(string line, out int[] arr)
    {
        bool flag = true;
        string[] arl = line.Split();
        arr = new int[arl.Length];
        for (int i = 0; i < arl.Length; i++)
        {
            if (!int.TryParse(arl[i], out arr[i]))
            {
                flag = false;
            }
        }
        return flag;

    }
    private static void Merge(int[] arr, int left, int right, int mid)
    {

        int l = left; 
        int m = mid;
        int[] arl = new int[right - left];
        int k = 0;
        while (l < mid && m < right)
        {

            if (arr[l] < arr[m])
            {
                arl[k] = arr[l];
                l++;
            }
            else
            {
                arl[k] = arr[m];
                m++;
            }
            k++;
        }
       
        for (int i = l; i <mid; i++)
        {
            arl[k] = arr[i];
            
            
            k+=1;
        }
       
        
        for (int i = m; i < right; i++)
        {
            arl[k] = arr[i];
            
            k++;
        }
        for (int i = 0; i < arl.Length; i++)
        {
            arr[left + i] = arl[i];
            
        }


    }
}