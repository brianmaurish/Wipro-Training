using System;

public class HelloWorld
{
    static int binarysearch(int[] num,int target)
    {
        int low=0;
        int high=num.Length-1;
        
        
        while(low<=high)
        {
            int mid=(low+high)/2;
            if(num[mid]==target)
            {
                return mid;
            }
            else if(num[mid]<target)
            {
                low=mid+1;
            }
            else
            {
                high=mid-1;
            }
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        int[] arr={1,2,3,4,5,6,7,8,9};
 
        int target = 9;
        int result=binarysearch(arr,target);
        
        if(result==-1)
        {
            Console.WriteLine("Element is not found");
        }
        else
        {
            Console.WriteLine("Element is found in index: "+result);
        }
    }
}