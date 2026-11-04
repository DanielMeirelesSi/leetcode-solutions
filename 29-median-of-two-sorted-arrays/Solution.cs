using System;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            int[] temporary = nums1;
            nums1 = nums2;
            nums2 = temporary;
        }

        int leftSize = (nums1.Length + nums2.Length + 1) / 2;
        int low = 0;
        int high = nums1.Length;

        while (low <= high)
        {
            int firstCut = low + (high - low) / 2;
            int secondCut = leftSize - firstCut;
            int firstLeft = firstCut == 0 ? int.MinValue : nums1[firstCut - 1];
            int firstRight = firstCut == nums1.Length ? int.MaxValue : nums1[firstCut];
            int secondLeft = secondCut == 0 ? int.MinValue : nums2[secondCut - 1];
            int secondRight = secondCut == nums2.Length ? int.MaxValue : nums2[secondCut];

            if (firstLeft <= secondRight && secondLeft <= firstRight)
            {
                int maximumLeft = Math.Max(firstLeft, secondLeft);
                if ((nums1.Length + nums2.Length) % 2 == 1)
                {
                    return maximumLeft;
                }
                return ((double)maximumLeft + Math.Min(firstRight, secondRight)) / 2;
            }

            if (firstLeft > secondRight)
            {
                high = firstCut - 1;
            }
            else
            {
                low = firstCut + 1;
            }
        }

        throw new InvalidOperationException("Não foi encontrada uma partição válida nos arrays ordenados.");
    }
}
