class Solution(object):
    def search(self, nums, target):
    
        low=0
        high=len(nums)-1
        #while it's not narrowed to one element
        while (low<=high):
            mid=(low+high)/2
            guess=nums[mid]
            if (target==guess):
                return mid
            if (target>guess):
                low=mid+1
            else: high=mid-1
            
        return -1
        