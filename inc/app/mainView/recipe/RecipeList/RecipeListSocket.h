#pragma once
#include"app/AppSocket.h"
#include"app/AppParser.h"

#include"app/DataModel/Groceries.h"

#include<string>

using namespace std;

class RecipeListSocket{
protected:
	AppSocket * mSocket;
public:
	RecipeListSocket(){
		mSocket = new AppSocket();
	}
	vector<string> getAllRecipe(){
		vector<string> msg;
		msg.push_back("Recipe");
		msg.push_back("GetAll");

		mSocket->sendData(AppParser::wrapMsg(msg));
		msg = AppParser::parsingMsg(mSocket->receiveData());

		return msg;
	}
	vector<string> searchRecipe(string keyWord){
		vector<string> msg;
		msg.push_back("Recipe");
		msg.push_back("Search");
		msg.push_back(keyWord);

		mSocket->sendData(AppParser::wrapMsg(msg));
		msg = AppParser::parsingMsg(mSocket->receiveData());

		return msg;
	}
	~RecipeListSocket(){
		delete mSocket;
	}
};
