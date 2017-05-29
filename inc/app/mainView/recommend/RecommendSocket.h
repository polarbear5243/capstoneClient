#pragma once
#include"app/AppSocket.h"
#include"app/AppParser.h"

#include<iostream>
#include<string>

using namespace std;

class RecommendSocket{
protected:
	AppSocket * mSocket;
public:
	RecommendSocket(){
		mSocket = new AppSocket();
	}
	vector<string> getRecommendRecipe(string recipeId){



	}
	~RecommendSocket(){
		delete mSocket;
	}
};
