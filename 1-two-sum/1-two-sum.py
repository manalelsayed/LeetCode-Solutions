class Solution(object):
    def twoSum(self, nums, target):
        for x in range (len(nums)):
            for y in range (x+1,len(nums)):
                if nums[y] + nums[x] == target:
                    return[x,y]
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
        