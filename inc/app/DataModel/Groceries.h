#pragma once
#include<string>

using namespace std;

class Groceries{
public:
	string mID;
	string mName;
public:
	Groceries(string id, string name){
		mID = id;
		mName = name;
	}
};
