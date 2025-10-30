/*
 * Problem: Two Sum
 * Difficulty: Easy
 * LeetCode: https://leetcode.com/problems/two-sum/
 * 
 * Description:
 * Given an array of integers nums and an integer target,
 * return indices of the two numbers that add up to target.
 * 
 * You may assume that each input would have exactly one solution,
 * and you may not use the same element twice.
 * 
 * Example 1:
 * Input: nums = [2,7,11,15], target = 9
 * Output: [0,1]
 * Explanation: nums[0] + nums[1] = 2 + 7 = 9
 * 
 * Example 2:
 * Input: nums = [3,2,4], target = 6
 * Output: [1,2]
 * 
 * Example 3:
 * Input: nums = [3,3], target = 6
 * Output: [0,1]
 * 
 * Pattern: Hash Map Complement Lookup
 * Time Complexity: O(n) - single pass through array
 * Space Complexity: O(n) - hash map stores up to n elements

 */

using System;
using System.Collections.Generic;

namespace PatternsPrep.Easy
{
    /// <summary>
    /// Two Sum - Find indices of two numbers that add up to target
    /// </summary>
    public class TwoSum
    {
        /// <summary>
        /// Finds two indices where nums[i] + nums[j] = target
        /// Uses hash map for O(1) complement lookups
        /// </summary>
        /// <param name="nums">Array of integers</param>
        /// <param name="target">Target sum</param>
        /// <returns>Array containing two indices [i, j]</returns>
        public int[] Solution(int[] nums, int target)
        {
            // Hash map to store: number -> index
            var map = new Dictionary<int, int>();
            
            // Iterate through array
            for (int i = 0; i < nums.Length; i++)
            {
                // Calculate the complement needed
                int complement = target - nums[i];
                
                // Check if complement exists in hash map
                if (map.ContainsKey(complement))
                {
                    // Found the pair! Return indices
                    return new int[] { map[complement], i };
                }
                
                // Store current number and its index for future lookups
                map[nums[i]] = i;
            }
            
            // No solution found (won't happen per problem constraints)
            return new int[] { };
        }
        
        /// <summary>
        /// Alternative: Brute force approach - O(n²) time
        /// Not recommended, included for comparison only
        /// </summary>
        /// <param name="nums">Array of integers</param>
        /// <param name="target">Target sum</param>
        /// <returns>Array containing two indices [i, j]</returns>
        public int[] BruteForce(int[] nums, int target)
        {
            // Check every possible pair
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            
            return new int[] { };
        }
    }
}