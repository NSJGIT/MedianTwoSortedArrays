public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        //Step 1 Merge
        var merged = nums1.Concat(nums2).OrderBy(n => n).ToArray();

        //Step 2 Take length
        double mergedLength=merged.Length;

        int medianLength=(int)Math.Floor(mergedLength/2);

        double isOdd=mergedLength%2;

        //if odd
        if (isOdd==1) {
            
            return merged[medianLength];

        }
        else {
            double median = (merged[medianLength - 1] + merged[medianLength]) / 2.0; //note here that indexation with arrays is such that the first element is zero

            return median;
        }
    }
}
//STEP 1
// solve the problem
//step 2, optimize

//merge arrays. optional?
//merged array needs to be sorted too
//from there we use length property divide by two, use that index if length is odd. if it's even divide by 2 for for index just above and/or below
