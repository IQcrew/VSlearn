#include <iostream>
#include <vector>
using namespace std;

int main()
{
	vector<int> nums = { 1, 2, 3, 4, 5, 3, 4,6,7,9,234 };

	int target = 3;
	vector<int> x = { -1, -1 };
	for (int i = 0; i < nums.size(); i++){if (nums[i] == target) { x[1] = i; }}
	for (int i = nums.size()-1; i > -1; i--) { if (nums[i] == target) { x[0] = i; } }
	for (int i = 0; i < 2; i++)
	{
		cout << x[i] << i << "   \n";
	}

}


