#pragma once
#include<vector>
#include<string>

using namespace std;

class AppParser{
private:
	static const string delimiter;
	static const string endStr;
public:
	static vector<string> parsingMsg(string str);
	static string wrapMsg(vector<string> str);
};
