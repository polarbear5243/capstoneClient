#pragma once
#include<string>
#include<list>

#include"Groceries.h"

using namespace std;

class UserInfo{
private:
	static UserInfo * mInstance;

public:
	static void init(string id){
		mInstance = new UserInfo(id);
	}
	static UserInfo * getInstance(){
		return mInstance;
	}

private:
	string mUserID;
	list<Groceries *> mUserGroceries;

private:
	UserInfo(string id){
		mUserID = id;
		mUserGroceries = list<Groceries *>();
	}
public:
	void addGroceries(string foodId,string foodName){
		mUserGroceries.push_back(new Groceries(foodId,foodName));
	}
	void deleteGroceries(string foodName){

		list<Groceries *>::iterator it;

		for(it=mUserGroceries.begin() ; it!=mUserGroceries.end();it++){
			if((*it)->mName.compare(foodName)==0){
				mUserGroceries.erase(it);
				return;
			}
		}
	}
	string getMyId(){
		return mUserID;
	}
	list<Groceries *> * getMyGroceries(){
		return &mUserGroceries;
	}
	bool isExist(string name){
		list<Groceries *>::iterator it;

		for(it=mUserGroceries.begin() ; it!=mUserGroceries.end();it++){
			if((*it)->mName.compare(name)==0){
				mUserGroceries.erase(it);
				return true;
			}
		}
		return false;
	}
};

UserInfo * UserInfo::mInstance = NULL;
