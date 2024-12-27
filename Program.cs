//*****************************************************************************
//** 1013. Partition Array Into Three Parts With Equal Sum          leetcode **
//*****************************************************************************

bool canThreePartsEqualSum(int* arr, int arrSize) {
    int totalSum = 0;

    for (int i = 0; i < arrSize; i++) 
    {
        totalSum += arr[i];
    }

    if (totalSum % 3 != 0) 
    {
        return false;
    }

    int targetSum = totalSum / 3;
    int currentSum = 0;
    int partitions = 0;

    for (int i = 0; i < arrSize; i++) 
    {
        currentSum += arr[i];

        if (currentSum == targetSum) 
        {
            partitions++;
            currentSum = 0;
        }

        if (partitions == 2 && i < arrSize - 1) 
        {
            return true;
        }
    }

    return false;
}