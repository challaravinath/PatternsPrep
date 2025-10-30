/*
 * Test Cases for: Two Sum
 * 
 * This file contains comprehensive test cases to verify the Two Sum solution.
 * Run this file to test your solution against various scenarios.
 * 
 * Test Coverage:
 * - Normal cases
 * - Edge cases (duplicates, negatives, zeros)
 * - Boundary cases (minimum size array)
 * - Large numbers
 */

using System;
using System.Linq;

namespace PatternsPrep.Easy.Tests
{
    /// <summary>
    /// Test suite for Two Sum problem
    /// </summary>
    public class TwoSumTests
    {
        private readonly TwoSum _solution;
        private int _totalTests;
        private int _passedTests;
        
        public TwoSumTests()
        {
            _solution = new TwoSum();
            _totalTests = 0;
            _passedTests = 0;
        }
        
        /// <summary>
        /// Runs all test cases
        /// </summary>
        public void RunAllTests()
        {
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║   🧪 Two Sum - Test Suite            ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine();
            
            // Run all tests
            Test1_NormalCase();
            Test2_DifferentOrder();
            Test3_SameNumberTwice();
            Test4_NegativeNumbers();
            Test5_LargeNumbers();
            Test6_ZeroTarget();
            Test7_TwoElementsMinimum();
            Test8_TargetAtBeginning();
            Test9_TargetAtEnd();
            Test10_WithZeros();
            
            // Print summary
            PrintSummary();
        }
        
        /// <summary>
        /// Test 1: Basic normal case
        /// </summary>
        private void Test1_NormalCase()
        {
            Console.WriteLine("Test 1: Normal Case");
            Console.WriteLine("─────────────────────");
            
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = { 0, 1 };
            
            var result = _solution.Solution(nums, target);
            bool passed = ValidateResult(result, expected, nums, target);
            
            PrintTestResult(
                input: "nums = [2,7,11,15], target = 9",
                output: $"[{result[0]}, {result[1]}]",
                expected: $"[{expected[0]}, {expected[1]}]",
                passed: passed
            );
            
            UpdateStats(passed);
        }
        
        /// <summary>
        /// Test 2: Numbers in different order
        /// </summary>
        private void Test2_DifferentOrder()
        {
            Console.WriteLine("Test 2: Numbers in Different Order");
            Console.WriteLine("─────────────────────────────────────");
            
            int[] nums = { 3, 2, 4 };
            int target = 6;
            int[] expected = { 1, 2 };
            
            var result = _solution.Solution(nums, target);
            bool passed = ValidateResult(result, expected, nums, target);
            
            PrintTestResult(
                input: "nums = [3,2,4], target = 6",
                output: $"[{result[0]}, {result[1]}]",
                expected: $"[{expected[0]}, {expected[1]}]",
                passed: passed
            );
            
            UpdateStats(passed);
        }
        
        /// <summary>
        /// Test 3: Same number appears twice (duplicates)
        /// </summary>
        private void Test3_SameNumberTwice()
        {
            Console.WriteLine("Test 3: Same Number Appears Twice");
            Console.WriteLine("────────────────────────────────────");
            
            int[] nums = { 3, 3 };
            int target = 6;
            int[] expected = { 0, 1 };
            
            var result = _solution.Solution(nums, target);
            bool passed = ValidateResult(result, expected, nums, target);
            
            PrintTestResult(
                input: "nums = [3,3], target = 6",
                output: $"[{result[0]}, {result[1]}]",
                expected: $"[{expected[0]}, {expected[1]}]",
                passed: passed
            );
            
            UpdateStats(passed);
        }
        
        /// <summary>
        /// Test 4: Array with negative numbers
        /// </summary>
        private void Test4_NegativeNumbers()
        {
            Console.WriteLine("Test 4: Negative Numbers");
            Console.WriteLine("──────────────────────────");
            
            int[] nums = { -1, -2, -3, -4, -5 };
            int target = -8;
            
            var result = _solution.Solution(nums, target);
            bool passed = nums[result[0]] + nums[result[1]] == target;
            
            PrintTestResult(
                input: "nums = [-1,-2,-3,-4,-5], target = -8",
                output: $"[{result[0]}, {result[1]}] => {nums[result[0]]} + {nums[result[1]]} = {nums[result[0]] + nums[result[1]]}",
                expected: "Any valid pair that sums to -8",
                passed: passed
            );
            
            UpdateStats(passed);
        }
        
        /// <summary>
        /// Test 5: Large numbers
        /// </summary>
        private void Test5_LargeNumbers()
        {
            Console.WriteLine("Test 5: Large Numbers");
            Console.WriteLine("────────────────────────");
            
            int[] nums = { 1000000, 2000000, 3000000 };
            int target = 3000000;
            int[] expected = { 0, 1 };
            
            var result = _solution.Solution(nums, target);
            bool passed = ValidateResult(result, expected, nums, target);
            
            PrintTestResult(
                input: "nums = [1000000,2000000,3000000], target = 3000000",
                output: $"[{result[0]}, {result[1]}]",
                expected: $"[{expected[0]}, {expected[1]}]",
                passed: passed
            );
            
            UpdateStats(passed);
        }
        
        /// <summary>
        /// Test 6: Target is zero
        /// </summary>
        private void Test6_ZeroTarget()
        {
            Console.WriteLine("Test 6: Target is Zero");
            Console.WriteLine("─────────────────────────");
            
            int[] nums = { -3, 0, 3, 4 };
            int target = 0;
            int[] expected = { 0, 2 };
            
            var result = _solution.Solution(nums, target);
            bool passed = ValidateResult(result, expected, nums, target);
            
            PrintTestResult(
                input: "nums = [-3,0,3,4], target = 0",
                output: $"[{result[0]}, {result[1]}]",
                expected: $"[{expected[0]}, {expected[1]}]",
                passed: passed
            );
            
            UpdateStats(passed);
        }
        
        /// <summary>
        /// Test 7: Minimum size array (2 elements)
        /// </summary>
        private void Test7_TwoElementsMinimum()
        {
            Console.WriteLine("Test 7: Minimum Size Array");
            Console.WriteLine("─────────────────────────────");
            
            int[] nums = { 1, 2 };
            int target = 3;
            int[] expected = { 0, 1 };
            
            var result = _solution.Solution(nums, target);
            bool passed = ValidateResult(result, expected, nums, target);
            
            PrintTestResult(
                input: "nums = [1,2], target = 3",
                output: $"[{result[0]}, {result[1]}]",
                expected: $"[{expected[0]}, {expected[1]}]",
                passed: passed
            );
            
            UpdateStats(passed);
        }
        
        /// <summary>
        /// Test 8: Target pair at beginning of array
        /// </summary>
        private void Test8_TargetAtBeginning()
        {
            Console.WriteLine("Test 8: Target at Beginning");
            Console.WriteLine("──────────────────────────────");
            
            int[] nums = { 5, 4, 11, 15 };
            int target = 9;
            int[] expected = { 0, 1 };
            
            var result = _solution.Solution(nums, target);
            bool passed = ValidateResult(result, expected, nums, target);
            
            PrintTestResult(
                input: "nums = [5,4,11,15], target = 9",
                output: $"[{result[0]}, {result[1]}]",
                expected: $"[{expected[0]}, {expected[1]}]",
                passed: passed
            );
            
            UpdateStats(passed);
        }
        
        /// <summary>
        /// Test 9: Target pair at end of array
        /// </summary>
        private void Test9_TargetAtEnd()
        {
            Console.WriteLine("Test 9: Target at End");
            Console.WriteLine("────────────────────────");
            
            int[] nums = { 2, 7, 11, 4 };
            int target = 15;
            int[] expected = { 2, 3 };
            
            var result = _solution.Solution(nums, target);
            bool passed = ValidateResult(result, expected, nums, target);
            
            PrintTestResult(
                input: "nums = [2,7,11,4], target = 15",
                output: $"[{result[0]}, {result[1]}]",
                expected: $"[{expected[0]}, {expected[1]}]",
                passed: passed
            );
            
            UpdateStats(passed);
        }
        
        /// <summary>
        /// Test 10: Array containing zeros
        /// </summary>
        private void Test10_WithZeros()
        {
            Console.WriteLine("Test 10: Array with Zeros");
            Console.WriteLine("───────────────────────────");
            
            int[] nums = { 0, 4, 3, 0 };
            int target = 0;
            int[] expected = { 0, 3 };
            
            var result = _solution.Solution(nums, target);
            bool passed = ValidateResult(result, expected, nums, target);
            
            PrintTestResult(
                input: "nums = [0,4,3,0], target = 0",
                output: $"[{result[0]}, {result[1]}]",
                expected: $"[{expected[0]}, {expected[1]}]",
                passed: passed
            );
            
            UpdateStats(passed);
        }
        
        /// <summary>
        /// Validates if the result is correct
        /// </summary>
        private bool ValidateResult(int[] result, int[] expected, int[] nums, int target)
        {
            // Check if result has two elements
            if (result.Length != 2)
                return false;
            
            // Check if indices are valid
            if (result[0] < 0 || result[0] >= nums.Length)
                return false;
            if (result[1] < 0 || result[1] >= nums.Length)
                return false;
            
            // Check if indices are different
            if (result[0] == result[1])
                return false;
            
            // Check if the sum equals target
            return nums[result[0]] + nums[result[1]] == target;
        }
        
        /// <summary>
        /// Prints test result in formatted style
        /// </summary>
        private void PrintTestResult(string input, string output, string expected, bool passed)
        {
            Console.WriteLine($"  📋 Input:    {input}");
            Console.WriteLine($"  📤 Output:   {output}");
            Console.WriteLine($"  ✓  Expected: {expected}");
            Console.WriteLine($"  {(passed ? "✅ PASS" : "❌ FAIL")}");
            Console.WriteLine();
        }
        
        /// <summary>
        /// Updates test statistics
        /// </summary>
        private void UpdateStats(bool passed)
        {
            _totalTests++;
            if (passed)
                _passedTests++;
        }
        
        /// <summary>
        /// Prints final test summary
        /// </summary>
        private void PrintSummary()
        {
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║           Test Summary                 ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine($"  Total Tests:  {_totalTests}");
            Console.WriteLine($"  Passed:       {_passedTests}");
            Console.WriteLine($"  Failed:       {_totalTests - _passedTests}");
            Console.WriteLine($"  Success Rate: {(_passedTests * 100.0 / _totalTests):F1}%");
            Console.WriteLine();
            
            if (_passedTests == _totalTests)
            {
                Console.WriteLine("  🎉 All tests passed! Great job! 🎉");
                Console.WriteLine("  ✅ Solution is correct and ready to submit!");
            }
            else
            {
                Console.WriteLine($"  ⚠️  {_totalTests - _passedTests} test(s) failed.");
                Console.WriteLine("  🔍 Review the failed tests above.");
            }
            
            Console.WriteLine();
            Console.WriteLine("════════════════════════════════════════");
        }
        
        /// <summary>
        /// Main entry point - runs all tests
        /// </summary>
        public static void Main()
        {
            var testSuite = new TwoSumTests();
            testSuite.RunAllTests();
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}