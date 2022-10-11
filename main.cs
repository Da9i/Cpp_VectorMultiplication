#include<iostream>
using namespace std;
int main()
{
	int arr1[3], arr2[3], result1 = 0, result2 = 0, result3 = 0;
	for (int i = 0; i < 3; i++)
	{
		if (i == 0)
		{
			cout << "ENTER U1 VECTOR VALUE:";
			cin >> arr1[i];
		}
		if (i == 0)
		{
			cout << "ENTER V1 VECTOR VALUE:";
			cin >> arr2[i];
		}
		if (i == 1)
		{
			cout << "ENTER U2 VECTOR VALUE:";
			cin >> arr1[i];
		}
		if (i == 1)
		{
			cout << "ENTER V2 VECTOR VALUE:";
			cin >> arr2[i];
		}
		if (i == 2)
		{
			cout << "ENTER U3 VECTOR VALUE:";
			cin >> arr1[i];
		}
		if (i == 2)
		{
			cout << "ENTER V3 VECTOR VALUE:";
			cin >> arr2[i];
		}
	}
	for (int i = 0; i < 3; i++)
	{
		if (i == 0)
		{
			result1 += (arr1[i + 1] * arr2[i + 2]) - (arr1[i + 2] * arr2[i + 1]);
			cout << "(U1,U2,U3)*(V1,V2,V3)= " << result1 << endl;
		}
		if (i == 1)
		{
			result2 += (arr1[i + 2] * arr2[i]) - (arr1[i] * arr2[i + 2]);
			cout << "(U1,U2,U3)*(V1,V2,V3)= " << result2 << endl;
		}
		if (i == 2)
		{
			result3 += (arr1[i] * arr2[i + 1]) - (arr1[i + 1] * arr2[i]);
			cout << "(U1,U2,U3)*(V1,V2,V3)= " << result3 << endl;
		}
	}
	system("pause>0");
}
