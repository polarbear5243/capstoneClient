#pragma once
#include"app/AppSocket.h"
#include"app/AppParser.h"

#include"app/DataModel/Groceries.h"

#include<iostream>
#include<string>

using namespace std;

class RecipeInfoSocket{
protected:
	AppSocket * mSocket;
public:
	RecipeInfoSocket(){
		mSocket = new AppSocket();
	}
	vector<string> getRecipe(string recipeId){
		vector<string> msg;
		msg.push_back("Recipe");
		msg.push_back("GetInfo");
		msg.push_back(recipeId);

		mSocket->sendData(AppParser::wrapMsg(msg));
		msg = AppParser::parsingMsg(mSocket->receiveData());

		return msg;
	}
	vector<string> evaluation(string userId, string recipeId, int score){
		vector<string> msg;
		msg.push_back("Recipe");
		msg.push_back("Evaluate");
		msg.push_back(userId);
		msg.push_back(recipeId);
		char str[20];
		sprintf(str,"%d",score);
		msg.push_back(str);

		mSocket->sendData(AppParser::wrapMsg(msg));
		msg = AppParser::parsingMsg(mSocket->receiveData());

		return msg;
	}
	~RecipeInfoSocket(){
		delete mSocket;
	}
};
